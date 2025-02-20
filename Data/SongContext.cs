using Microsoft.EntityFrameworkCore;
using MusicApi.Models;//import models

namespace MusicApi.Data {

    //SongContext inherit from DbContext. Connection between application and database
    public class SongContext : DbContext {

        //constructor handles DbContext options and send to base class DbContext
        public SongContext(DbContextOptions<SongContext> options) : base(options) {

        }

        //creating tables in database
        public DbSet<Song> Songs {get; set;}
       
    }
}