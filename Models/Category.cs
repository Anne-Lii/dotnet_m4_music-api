using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models {
    public class Category {

        //Properties
        public int CategoryId { get; set; }

        [Required]
        public string? Title { get; set; }
       
        // Navigation property, a category could have many songs
        public ICollection<Song>? Songs { get; set; }
    }
}