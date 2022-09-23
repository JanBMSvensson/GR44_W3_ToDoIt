namespace UnitTests
{
    public class PersonTests
    {

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewPerson_FirstNameNullOrEmptyShouldFail(string firstName)
        {
            Exception? result = Assert.Throws<Exception>(() => new Person(1, firstName, "Svensson"));
            Assert.NotNull(result);
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewPerson_LastNameNullOrEmptyShouldFail(string lastName)
        {
            Exception? result = Assert.Throws<Exception>(() => new Person(1, "Joe", lastName));
            Assert.NotNull(result);
        }

        [Fact]
        public void NewPerson_VerifyID()
        {
            int TestValue = 43153;
            Person Test = new(TestValue, "Jan", "Svensson");
            Assert.Equal(TestValue, Test.ID);
        }

        [Fact]
        public void NewPerson_VerifyFirstName()
        {
            string TestValue = "Janne";
            Person Test = new(1, TestValue, "Svensson");
            Assert.Equal(TestValue, Test.FirstName);
        }

        [Fact]
        public void NewPerson_VerifyLastName()
        {
            string TestValue = "Svensson";
            Person Test = new(1, "Jan", TestValue);
            Assert.Equal(TestValue, Test.LastName);
        }

    }
}