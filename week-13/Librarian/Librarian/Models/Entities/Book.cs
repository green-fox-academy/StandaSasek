﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public List<Category> Categories { get; set; }
        public DateTime Registered { get; set; }
        public Librarian RegisteredBy { get; set; }
        public bool Destroyed { get; set; }

        public Book()
        {
        }
    }
}
