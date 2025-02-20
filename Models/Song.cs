using System.ComponentModel.DataAnnotations;

namespace MusicApi.Models {
    public class Song {

        //Properties
        [Key]
        public int SongId { get; set; } //PK

        [Required(ErrorMessage ="Ange en artist")]
        public string? Artist { get; set; }

        [Required(ErrorMessage ="Ange en titel på en sång")]
        public string? Title { get; set; }

        [Required(ErrorMessage ="Ange längden i sekunder")]
        public int Length { get; set; }
        
        
        
        public int CategoryId { get; set; } //FK
        public virtual Category? Category { get; set; }
    }
}