using System;

namespace Library.Domain.Model
{
    public class BookModelUpdate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Interpreter { get; set; }
        public DateTime Launch { get; set; }
        public double? Price { get; set; }
        public string Language { get; set; }
    }
}
