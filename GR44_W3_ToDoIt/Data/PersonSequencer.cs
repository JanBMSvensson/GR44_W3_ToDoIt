namespace GR44_W3_ToDoIt.Data
{
    internal class PersonSequencer
    {
        private static int personId = default;
        public static object LockingDummy = new object(); // not really a multi threaded environment but the tests are

        public static int NextPersonId() => ++personId;
        public static void Reset() => personId = default;

    }
}
