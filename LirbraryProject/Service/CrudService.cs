using LibraryProject.Models;
using LirbraryProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LirbraryProject.Service 
{
    public class CrudService : ICrudService
    {
        private readonly ApplicationDbContext _context;
        public CrudService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void InsertBookSet(BooksSetModel bookSet)
        {
            throw new NotImplementedException();
        }

        public void InsertLibrary(LibraryModel library)
        {
            throw new NotImplementedException();
        }

        public void InsertShelf(ShelfModel shelf)
        {
            throw new NotImplementedException();
        }
        void ICrudService.InsertBook(BookModel book)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public bool UpdateBook(BookModel vbook)
        {
            BookModel? ToUpdate = _context.Books.Find(vbook.Id);
            if (ToUpdate == null) return false;
            ToUpdate.BookName = vbook.BookName;
            ToUpdate.Height = vbook.Height;
            ToUpdate.Width = vbook.Width;
            ToUpdate.BooksSet = vbook.BooksSet;
            ToUpdate.BooksSetId = vbook.BooksSetId;
            if (CheckerWidthShelf(vbook.BooksSetId)) ;
            int res =_context.SaveChanges();
            return res!=0;
       
        }
        [HttpPost]
        public void UpdateBookSet(BooksSetModel bookSet)
        {
            BooksSetModel? ToUpdate = _context.BooksSets.Find(bookSet.Id);
        }
        [HttpPost]
        public void UpdateLibrary(LibraryModel library)
        {
            _context.Update(library);
        }
        [HttpPost]
        public void UpdateShelf(ShelfModel shelf)
        {
            _context.Update(shelf);
        }

        public bool CheckerWidthShelf(long  newSet)
        {
            var shelf = _context.Shelves.
                Include(s => s.BooksSets)
                .ThenInclude(bs => bs.Books)
                .FirstOrDefault(s => s.Id == newSet);
            if (shelf == null) return false;
            var res1 = shelf.BooksSets.Where(bs => bs.Id != newSet)
                .SelectMany(bs => bs.Books)
                
                .Sum(b => b.Width);
            return res1 + shelf.BooksSets.FirstOrDefault(bs => bs.Id == newSet)!.Books.Sum(b => b.Width) < shelf.Width;
            //newSet.Books.Sum(b => b.Width) < shelf.Width;

        }


        




    }
}
/*
 * 
        [HttpGet]
        public BookModel? UpdateBook(long id)
        {
            BookModel book = _context.books.Find(id);
            if (book == null)
                return null;
            return book;
                
        }
        [HttpGet]
        public BooksSetModel UpdateBookSet(long id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public ShelfModel UpdateShelf(long id)
        {
            throw new NotImplementedException();
        }
        [HttpGet]
        public LibraryModel UpdateLibrary(long id)
        {
            throw new NotImplementedException();
        }
 * */
