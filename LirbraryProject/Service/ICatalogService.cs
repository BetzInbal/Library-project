using LibraryProject.Models;

namespace LirbraryProject.Service
{
    public interface ICatalogService
    {
        IEnumerable<BookModel> GetBooksByGenre(string genre);
        IEnumerable<BookModel> GetBooksBySetName(string setName);
        IEnumerable<BookModel> GetBooks(string bookName);
    }
}
