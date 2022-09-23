namespace GR44_W3_ToDoIt.Data
{
    internal class PeopleService
    {
        private static Person[] persons = Array.Empty<Person>();
        public static object LockingDummy = new object();

        public int Size => persons.Length;

        public Person[] FindAll() => persons;
        public void Clear() => persons = Array.Empty<Person>();
        public Person FindById(int personId) => persons.Where(p => p.ID == personId).FirstOrDefault((Person?)null) ?? throw new Exception($"PersonId {personId} couldn't be found!");
        public Person CreateNewPerson(string firstName, string lastName)
        {
            Array.Resize(ref persons, persons.Length + 1);
            persons[^1] = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            return persons[^1]; // return the last item (the 1st from the end)
        }

    }
}
