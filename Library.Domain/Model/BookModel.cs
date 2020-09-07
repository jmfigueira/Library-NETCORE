using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Model
{
    public class BookModel
    {
        public BookModel(int id, string name, string description, string author)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
