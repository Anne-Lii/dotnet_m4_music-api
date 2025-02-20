using Microsoft.EntityFrameworkCore;
using MusicApi.Models;

namespace MusicApi.Data {
    public class SongContext : DbContext {
        public SongContext(DbContextOptions<SongContext> options) : base(options) {

        }

        //creating tables in database
        public DbSet<Song> Songs {get; set;}
        public DbSet<Category> Categories {get; set;}
    }
}