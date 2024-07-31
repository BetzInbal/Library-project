using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    [Index(nameof(Genre), IsUnique = true)]
    public class LibraryModel
    {
        public long Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength =4)]

        public required string  Genre { get; set; }
        public IEnumerable<ShelfModel> Shelves { get; set; } = [];
    }
}

