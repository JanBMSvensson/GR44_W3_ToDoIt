namespace GR44_W3_ToDoIt.Data
{
    internal class ToDoSequencer
    {
        private static int toDoItemId = default;
        public static object LockingDummy = new object();

        public static int NextToDoItemID() => ++toDoItemId;
        public static void Reset() => toDoItemId = default;
    }
}
