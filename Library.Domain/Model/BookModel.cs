using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Model
{
    public class BookModel
    {
        public BookModel(int id, string title, string description,
            string author, string interpreter, string language, DateTime? launch, double? price)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            Interpreter = interpreter;
            Launch = launch ?? DateTime.Now;
            Price = price;
            Language = language;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Interpreter { get; set; }
        public DateTime? Launch { get; set; }
        public double? Price { get; set; }
        public string Language { get; set; }
    }
}
