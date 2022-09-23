namespace UnitTests
{
    // [Collection("Single Test")] ... could maybe be an option instead of locks (different test classes run on separate threads but this *might* make them work as a single test class)
    public class PersonSequencerTests
    {

        [Fact]
        public void TestIdSequence()
        {
            lock (PersonSequencer.LockingDummy)
            {
                PersonSequencer.Reset();
                Assert.Equal(1, PersonSequencer.NextPersonId());
                Assert.Equal(2, PersonSequencer.NextPersonId());
                Assert.Equal(3, PersonSequencer.NextPersonId());
                Assert.Equal(4, PersonSequencer.NextPersonId());
                PersonSequencer.Reset();
                Assert.Equal(1, PersonSequencer.NextPersonId());
                Assert.Equal(2, PersonSequencer.NextPersonId());
                Assert.Equal(3, PersonSequencer.NextPersonId());
            }
        }
    }
}
