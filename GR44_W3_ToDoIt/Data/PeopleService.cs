using GR44_W3_ToDoIt.Models;

namespace GR44_W3_ToDoIt.Data
{
    internal class PeopleService
    {
        private static Person[] persons = new Person[0];

        public int Size() { return persons.Length; }
        public Person[] FindAll() { return persons; }
        public Person FindById(int personId)
        {
            foreach (Person item in persons)
                if(item.ID == personId)
                    return item;

            throw new Exception($"PersonId {personId} couldn't be found!");
        }
        public Person CreateNewPerson(string firstName, string lastName)
        {
            Array.Resize(ref persons, persons.Length + 1);
            persons[persons.Length] = new Person(PersonSequencer.NextPersonId(), firstName, lastName);
            return persons[persons.Length - 1];
        }

        public void Clear() { persons = new Person[0]; }
    }
}
