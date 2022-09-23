
namespace UnitTests
{
    public class ToDoServiceTests
    {
        [Fact]
        public void NewService_ShouldBeEmpty()
        {
            lock (ToDoService.LockingDummy)
            {
                ToDoService toDoService = new();
                toDoService.Clear();
                Assert.Equal(0, toDoService.Size);
            }
        }

        [Fact]
        public void CreateNewToDo()
        {
            string Test1 = "My super nice task to do if I ever would get some free time";

            lock (ToDoService.LockingDummy)
            {
                lock (ToDoSequencer.LockingDummy)
                {
                    ToDoService service = new();
                    service.Clear();

                    ToDo NewToDo = service.CreateNewToDoItem(Test1);
                    Assert.NotNull(NewToDo);
                    Assert.Equal(Test1, NewToDo.Description);
                }
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void FindToDoItemByID_Found(int testID)
        {
            lock (PeopleService.LockingDummy)
            {
                lock (PersonSequencer.LockingDummy)
                {
                    ToDoService TDS = new();
                    ToDoSequencer.Reset();
                    TDS.CreateNewToDoItem("Description 1");
                    TDS.CreateNewToDoItem("Description 2");
                    TDS.CreateNewToDoItem("Description 3");

                    Assert.Equal(testID, TDS.FindById(testID)?.ID ?? -1);
                }
            }
        }

        [Fact]
        public void FindToDoItemByID_NotFoundShouldFail()
        {
            ToDoService TDS = new();
            Exception result = Assert.Throws<Exception>(() => TDS.FindById(-1));
            Assert.NotNull(result);
        }

    }
}
