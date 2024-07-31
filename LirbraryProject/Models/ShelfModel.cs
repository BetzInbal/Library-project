using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{


    public class ShelfModel
    {
        public long Id { get; set; }
        [Required]
        public required float Width { get; set; }
        [Required]
        public required float Height { get; set; }
        public LibraryModel Library { get; set; }
        public long LibraryId { get; set; }
        public IEnumerable<BooksSetModel> BooksSets { get; set; } = [];
    }
}