
namespace GR44_W3_ToDoIt.Data
{
    internal class PersonSequencer
    {
        private static int personId = default;
        private static object dummy = new object(); // not really a multi threaded environment but the tests are

        public static int NextPersonId()
        {
            lock (dummy)
            {
                return ++personId;
            }
        }

        public static void Reset()
        {
            lock (dummy)
            {
                personId = 0;
            }
        }
    }
}
