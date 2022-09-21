
namespace GR44_W3_ToDoIt.Data
{
    internal class ToDoSequencer
    {
        private static int toDoItemId = default;
        private static object dummy = new object(); // not really a multi threaded environment but the tests are

        public static int NextToDoItemID()
        {

            lock (dummy)
            {
                return ++toDoItemId;
            }
        }

        public static void Reset()
        {
            lock (dummy)
            {
                toDoItemId = 0;
            }
        }
    }
}
