using LibraryProject.Models;
using LirbraryProject.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LirbraryProject.Service
{
    public class CatalogService : ICatalogService
    {
        private readonly ApplicationDbContext _context;
        public CatalogService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BookModel> GetBooks(string bookName)
        {
            return _context.Books.Where(x => x.BookName == bookName).ToList();
        }

        public IEnumerable<BookModel> GetBooksByGenre(string genre)
        {
            return _context.Books.Where(x => x.Genre == genre).ToList();
        }


        public IEnumerable<BookModel> GetBooksBySetName(string setName)
        {
            return _context.BooksSets
                 .Where(bs => bs.SetName == setName)
                 .Include(bs => bs.Books)
                 .SelectMany(bs => bs.Books);
               


        }
    }


}
