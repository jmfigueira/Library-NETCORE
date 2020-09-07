namespace Library.Domain.Entities
{
    public class Book : BaseEntity<int>
    {
        public Book(int id, string name, string description, string author) : base(id)
        {
            Name = name;
            Description = description;
            Author = author;
        }

        public string Name { get; }
        public string Description { get; }
        public string Author { get; set; }
    }
}
