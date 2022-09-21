using GR44_W3_ToDoIt.Models;

namespace GR44_W3_ToDoIt.Data
{
    internal class ToDoService
    {
        private static ToDo[] toDoItems = new ToDo[0];

        public int Size() { return toDoItems.Length; }
        public ToDo[] FindAll() { return toDoItems; }
        public ToDo FindById(int toDoId)
        {
            foreach (ToDo item in toDoItems)
                if (item.ID == toDoId)
                    return item;

            throw new Exception($"ToDoId {toDoId} couldn't be found!");
        }
        public ToDo CreateNewToDoItem(string description)
        {
            Array.Resize(ref toDoItems, toDoItems.Length + 1);
            toDoItems[toDoItems.Length] = new ToDo(ToDoSequencer.NextToDoItemID(), description);
            return toDoItems[toDoItems.Length - 1];
        }

        public void Clear() { toDoItems = new ToDo[0]; }

        public ToDo[] FindByDoneStatus(bool doneStatus)
        {
            return toDoItems.Where(todoItem => todoItem.Done == doneStatus).ToArray();
        }

        public ToDo[] FindByAssignee(int personId)
        {
            return toDoItems.Where(toDoItems => toDoItems.Assignee?.ID == personId).ToArray();
        }

        public ToDo[] FindByAssignee(Person assignee)
        {
            return toDoItems.Where(toDoItems => toDoItems.Assignee == assignee).ToArray();
        }

        public ToDo[] FindUnassignedTodoItems()
        {
            return toDoItems.Where(toDoItems => toDoItems.Assignee is null).ToArray();
        }

        public void RemoveToDoItem(ToDo removeItem)
        {
            toDoItems = toDoItems.Where(item => item != removeItem).ToArray();
        }
    }
}
