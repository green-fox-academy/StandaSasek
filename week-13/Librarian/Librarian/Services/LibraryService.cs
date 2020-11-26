using LibrarianSystem.Database;
using LibrarianSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarianSystem.Services
{
    public class LibraryService
    {
        private readonly ApplicationDbContext dbContext;

        public LibraryService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User Login(string login, string password)
        {
            var entityUser = dbContext.Users.FirstOrDefault(u => u.Login.Equals(login) && u.Password.Equals(password));
            return entityUser;
        }
        internal bool RegisterUser(string name, string login, string password)
        {
            if (dbContext.Users.FirstOrDefault(u => u.Login.Equals(login)) != null)
            {
                return false;
            }
            var newUser = new User(name, login, password);
            newUser.Registered = DateTime.Now;
            dbContext.Users.Add(newUser);
            dbContext.SaveChanges();

            return true;
        }
        internal bool AddBook(string name, string author, User librarian) // TODO add some checking
        {
            var newBook = new Book(name, author, librarian);
            dbContext.Books.Add(newBook);
            dbContext.SaveChanges();

            return true;
        }
        internal User GetDefaultLibrarian()
        {
            var librarian = dbContext.Users.FirstOrDefault(u => u.Librarian);

            return librarian;
        }
        internal List<User> GetClients()
        {
            var clients = dbContext.Users.Where(u => !u.Librarian).ToList();

            return clients;
        }
        internal User GetClientByName(string name)
        {
            var client = dbContext.Users.FirstOrDefault(u => u.Name.Equals(name));

            return client;
        }
        internal List<User> GetLibrarians()
        {
            var librarians = dbContext.Users.Where(u => u.Librarian).ToList();

            return librarians;
        }
        internal List<Book> GetBooks()
        {
            var books = dbContext.Books.ToList();

            return books;
        }
        internal Book GetBookByName(string name)
        {
            var book = dbContext.Books.FirstOrDefault(u => u.Name.Equals(name));

            return book;
        }
        internal List<Borrow> GetBorrows()
        {
            var borrows = dbContext.Borrows.Include(b => b.BorrowedBook).Include(b => b.BorrowedByClient).ToList();

            return borrows;
        }
        internal Borrow GetBorrowByClientAndBook(Book book, User client)
        {
            var borrow = dbContext.Borrows.Include(b => b.BorrowedBook).Include(b => b.BorrowedByClient)
                .FirstOrDefault(b => b.BorrowedBook.Equals(book) && b.BorrowedByClient.Equals(client));

            return borrow;
        }
        internal List<Book> GetAvailableBooks()
        {
            var borrowedBooksId = dbContext.Borrows.Where(b => !b.RealEnd.HasValue).Select(b => b.BookId).ToList();
            var books = dbContext.Books.Where(book => !borrowedBooksId.Any(borrow => borrow == book.Id)).ToList();

            return books;
        }
        internal bool AddBorrow(Book book, User client) // TODO add some checking
        {
            var newBorrow = new Borrow(book, client);
            newBorrow.Start = DateTime.Today;
            newBorrow.PlannedEnd = newBorrow.Start.AddDays(14);

            dbContext.Borrows.Add(newBorrow);
            dbContext.SaveChanges();
            return true;
        }
        internal bool EndBorrow(Book book, User client) // TODO add some checking
        {
            var borrow = GetBorrowByClientAndBook(book, client);
            if (borrow.RealEnd.HasValue)
            {
                return false;
            }
            borrow.RealEnd = DateTime.Today;

            dbContext.Borrows.Add(borrow);
            dbContext.SaveChanges();
            return true;
        }
    }
}
