
namespace UnitTests
{
    public class PersonSequencerTests
    {
        [Fact] public void TestIncrement1() { Assert.Equal(1, PersonSequencer.NextPersonId()); }
        [Fact] public void TestIncrement2() { Assert.Equal(2, PersonSequencer.NextPersonId()); }
        [Fact] public void TestIncrement3() { Assert.Equal(3, PersonSequencer.NextPersonId()); }
        [Fact] public void TestIncrement4() { Assert.Equal(4, PersonSequencer.NextPersonId()); }
        [Fact] public void TestIncrement5() { Assert.Equal(5, PersonSequencer.NextPersonId()); }
        [Fact] public void TestIncrement6() { Assert.Equal(6, PersonSequencer.NextPersonId()); }
        [Fact] public void TestReset() { PersonSequencer.Reset(); Assert.Equal(1, PersonSequencer.NextPersonId()); }
    }
}
