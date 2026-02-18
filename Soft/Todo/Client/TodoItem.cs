namespace Abc.Soft.Todo.Client
{
    public class TodoItem
    {
        public string Title { get; set; } // cause nullable is disabled
        public bool IsDone { get; set; }
    }
}
