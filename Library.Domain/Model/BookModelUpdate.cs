﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Domain.Model
{
    public class BookModelUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
    }
}
