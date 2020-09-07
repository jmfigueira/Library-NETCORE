using System;

namespace Library.Domain.Entities
{
    public class Book : BaseEntity<int>
    {
        public Book(int id, string title, string description,
            string author, string interpreter, string language, DateTime? launch, double? price) : base(id)
        {
            Title = title;
            Description = description;
            Author = author;
            Interpreter = interpreter;
            Launch = launch;
            Price = price;
            Language = language;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Interpreter { get; set; }
        public DateTime? Launch { get; set; }
        public double? Price { get; set; }
        public string Language { get; set; }
    }
}
