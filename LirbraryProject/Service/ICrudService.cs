using LibraryProject.Models;
using System;

namespace LirbraryProject.Service
{
    public interface ICrudService
    {
        void InsertBook(BookModel book);
        void InsertBookSet(BooksSetModel bookSet);
        void InsertShelf(ShelfModel shelf);
        void InsertLibrary(LibraryModel library);

        bool UpdateBook(BookModel book);
        void UpdateBookSet(BooksSetModel bookSet);
        void UpdateShelf(ShelfModel shelf);
        void UpdateLibrary(LibraryModel library);
        bool CheckerWidthShelf(ShelfModel shelf, BooksSetModel newSet );
    }
}
/*
 * 
 * 
 * 
 * 
 * 
 * 
         BookModel UpdateBook(long id);
        BooksSetModel UpdateBookSet(long id);
        ShelfModel UpdateShelf(long id);
        LibraryModel UpdateLibrary(long id);
*/
