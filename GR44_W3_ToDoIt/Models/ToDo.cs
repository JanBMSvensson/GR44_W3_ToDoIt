namespace GR44_W3_ToDoIt.Models
{
    internal class ToDo
    {
        internal int ID { get => Id; }
        private readonly int Id; // As instructed

        internal string Description
        {
            get => description;
            [MemberNotNull(nameof(description))]
            set => description = value?.Length > 0 ? value : throw new Exception($"{nameof(description)} can't be empty!");
        }
        private string description;

        internal bool Done { get => done; set => done = value; }
        private bool done;

        internal Person? Assignee { get => assignee; set => assignee = value; }
        private Person? assignee;


        internal ToDo(int id, string description)
        {
            Id = id;
            Description = description;
            Done = false;
            Assignee = null;
        }
    }
}
