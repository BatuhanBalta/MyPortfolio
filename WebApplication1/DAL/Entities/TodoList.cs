namespace MyPortfolio.DAL.Entities
{
    public class TodoList
    {
        public int ToDoListId { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public DateTime DateTime { get; set; }

        public bool Status { get; set; }

    }
}
