using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Borrow> BorrowedBooks { get; set; }
        public DateTime Registered { get; set; }

        public Client()
        {
        }
    }
}
