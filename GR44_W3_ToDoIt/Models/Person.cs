namespace GR44_W3_ToDoIt.Models
{
    public class Person
    {
        public int ID { get => Id; }
        private readonly int Id; // As instructed

        public string FirstName 
        { 
            get => firstName;
            [MemberNotNull(nameof(firstName))] set => firstName = value?.Length > 0 ? value : throw new Exception($"{nameof(FirstName)} can't be empty!");
        }
        private string firstName;

        public string LastName 
        {
            get => lastName; 
            [MemberNotNull(nameof(lastName))] set => lastName = value?.Length > 0 ? value : throw new Exception($"{nameof(LastName)} can't be empty!");
        }
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
