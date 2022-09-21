
[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace UnitTests
{
    public class ToDoSequencerTests
    {

        //[Theory]
        //[InlineData(1)]
        //[InlineData(2)]
        //[InlineData(3)]
        //public void TestIncrement(int expectedValue)
        //{
        //    Assert.Equal(expectedValue, ToDoSequencer.NextToDoItemID());
        //}

        [Fact] public void TestIncrement1() { Assert.Equal(1, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestIncrement2() { Assert.Equal(2, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestIncrement3() { Assert.Equal(3, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestIncrement4() { Assert.Equal(4, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestIncrement5() { Assert.Equal(5, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestIncrement6() { Assert.Equal(6, ToDoSequencer.NextToDoItemID()); }
        [Fact] public void TestReset() { ToDoSequencer.Reset(); Assert.Equal(1, ToDoSequencer.NextToDoItemID()); }
    }
}
