namespace UnitTests
{
    public class PeopleServiceTests
    {
        [Fact]
        public void NewService_ShouldBeEmpty()
        {
            lock(PeopleService.LockingDummy)
            {
                PeopleService peopleService = new();
                peopleService.Clear();
                Assert.Equal(0, peopleService.Size);
            }
        }

        [Fact]
        public void CreateNewPerson()
        {
            string Test1 = "Jan";
            string Test2 = "Svensson";

            lock (PeopleService.LockingDummy)
            {
                lock (PersonSequencer.LockingDummy)
                {
                    PeopleService service = new();
                    service.Clear();

                    Person NewPerson = service.CreateNewPerson(Test1, Test2);
                    Assert.NotNull(NewPerson);
                    Assert.Equal(Test1, NewPerson.FirstName);
                    Assert.Equal(Test2, NewPerson.LastName);
                }
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void FindPersonByID_Found(int testID)
        {
            lock (PeopleService.LockingDummy)
            {
                lock (PersonSequencer.LockingDummy)
                {
                    PeopleService PS = new();
                    PersonSequencer.Reset();
                    PS.CreateNewPerson("Jan the 1st", "Svensson");
                    PS.CreateNewPerson("Jan the 2nd", "Svensson");
                    PS.CreateNewPerson("Jan the 3rd", "Svensson");

                    Assert.Equal(testID, PS.FindById(testID)?.ID ?? -1);
                }
            }
        }

        [Fact]
        public void FindPersonByID_NotFoundShouldFail()
        {
            PeopleService PS = new();
            Exception result = Assert.Throws<Exception>(() => PS.FindById(-1));
            Assert.NotNull(result);
        }

    }
}
