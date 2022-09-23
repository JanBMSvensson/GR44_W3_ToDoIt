// [assembly: CollectionBehavior(DisableTestParallelization = true)] ... moved to xunit.runner config

namespace UnitTests
{
    public class ToDoSequencerTests
    {
        [Fact] public void TestIdSequence()
        {
            lock(ToDoSequencer.LockingDummy)
            {
                ToDoSequencer.Reset();
                Assert.Equal(1, ToDoSequencer.NextToDoItemID());
                Assert.Equal(2, ToDoSequencer.NextToDoItemID());
                Assert.Equal(3, ToDoSequencer.NextToDoItemID());
                Assert.Equal(4, ToDoSequencer.NextToDoItemID());
                ToDoSequencer.Reset();
                Assert.Equal(1, ToDoSequencer.NextToDoItemID());
                Assert.Equal(2, ToDoSequencer.NextToDoItemID());
                Assert.Equal(3, ToDoSequencer.NextToDoItemID());
            }
        }
    }
}
