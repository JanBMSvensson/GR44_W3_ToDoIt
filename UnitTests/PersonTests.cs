


namespace UnitTests
{
    public class PersonTests
    {
        //[Fact]
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewPerson_FirstNameNullOrEmpty(string? firstName)
        {
            Exception? result = Assert.Throws<Exception>(() => new Person(1, firstName, "Svensson"));
            Assert.NotNull(result);
        }


        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void NewPerson_LastNameNullOrEmpty(string? lastName)
        {
            Exception? result = Assert.Throws<Exception>(() => new Person(1, "Joe", lastName));
            Assert.NotNull(result);
        }
    }
}