namespace UnitTests
{
    public class ToDoTests 
    {
        [Fact]
        public void NewToDo_ShouldNotBeFlaggedAsDone()
        {
            ToDo Test = new(1, "description");
            Assert.False(Test.Done);
        }

        [Fact]
        public void NewToDo_ShouldNotBeAssignedToAnyone()
        {
            ToDo Test = new(1, "description");
            Assert.Null(Test.Assignee);
        }
        
        [Fact]
        public void NewToDo_VerifyId()
        {
            int TestValue = 13249;
            ToDo Test = new(TestValue, "description");
            Assert.Equal(TestValue, Test.ID);
        }

        [Fact]
        public void NewToDo_VerifyComment()
        {
            string TestValue = "My very own special test comment that's very long.";
            ToDo Test = new(1, TestValue);
            Assert.Equal(TestValue, Test.Description);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewToDo_CommentNullOrEmptyShouldFail(string comment)
        {
            Exception? result = Assert.Throws<Exception>(() => new ToDo(1, comment));
            Assert.NotNull(result);
        }
    }
}
