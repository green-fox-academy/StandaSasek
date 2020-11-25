using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Models.Entities
{
    public class Borrow
    {
        public int Id { get; set; }
        public Client BorrowedByClient { get; set; }
        public int BorrowerClientId { get; set; }
        public Book BorrowedBook { get; set; }
        public int BookId { get; set; }
        public DateTime Start { get; set; }
        public DateTime PlannedEnd { get; set; }
        public DateTime? RealEnd { get; set; }
        public int Penalty { get; set; }
     
        public Borrow()
        {
        }
    }
}
