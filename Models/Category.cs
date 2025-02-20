using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models {
    public class Category {

        //Properties
        public int Id { get; set; } //PK

        [Required]
        public string? Title { get; set; }
       
        // Navigation property, a category could have many songs
        public List<Song>? Songs { get; set; }
    }
}