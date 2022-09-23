namespace GR44_W3_ToDoIt.Data
{
    internal class ToDoService
    {
        private static ToDo[] toDoItems = Array.Empty<ToDo>();
        public static object LockingDummy = new object();

        public int Size => toDoItems.Length;

        public ToDo CreateNewToDoItem(string description)
        {
            // Testing the hat-operator / from-end-operator
            Array.Resize(ref toDoItems, toDoItems.Length + 1);
            toDoItems[^1] = new ToDo(ToDoSequencer.NextToDoItemID(), description);
            return toDoItems[^1]; // return the last item (the 1st from the end)
        }
        public ToDo[] FindAll() => toDoItems;
        public ToDo FindById(int toDoId) => toDoItems.Where(toDoItems => toDoItems.ID == toDoId).FirstOrDefault((ToDo?)null) ?? throw new Exception($"{nameof(toDoId)} {toDoId} couldn't be found!");
        public void Clear() => toDoItems = Array.Empty<ToDo>();
        public ToDo[] FindByDoneStatus(bool doneStatus) => toDoItems.Where(todoItem => todoItem.Done == doneStatus).ToArray();
        public ToDo[] FindByAssignee(int personId) => toDoItems.Where(toDoItems => toDoItems.Assignee?.ID == personId).ToArray();
        public ToDo[] FindByAssignee(Person assignee) => toDoItems.Where(toDoItems => toDoItems.Assignee == assignee).ToArray();
        public ToDo[] FindUnassignedTodoItems() => toDoItems.Where(toDoItems => toDoItems.Assignee is null).ToArray();
        public void RemoveToDoItem(ToDo removeItem) => toDoItems = toDoItems.Where(item => item != removeItem).ToArray();
    }
}
