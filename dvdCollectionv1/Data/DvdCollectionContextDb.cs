using Microsoft.EntityFrameworkCore;
using dvdCollection.Models;

namespace dvdCollection.Data
{
    class DvdCollectionContextDb : DbContext
    {
        public DvdCollectionContextDb (DbContextOptions<DvdCollectionContextDb> options) : base(options)
        {

        }
        
        public DbSet<Actors> Actors {get; set;}
        public DbSet<Certificates> Certificates {get; set;}
        public DbSet<FilmGeneres> FilmGeneres {get; set;}
        public DbSet<FilmsActorRoles> FilmsActorRoles {get; set;}
        public DbSet<FilmTitles> FilmTitles {get; set;}
        public DbSet<FilmTitlesProducers> FilmTitlesProducers {get; set;}
        public DbSet<Producers> Producers {get; set;}
        public DbSet<RoleTypes> RoleTypes {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<FilmTitlesProducers>().HasKey(c => c.ProducerID, c.FilmTitleID);
            modelBuilder.Entity<FilmTitlesActorsRoles>().HasKey(c => c.ActorID, c.FilmTitleID, c.RoleTypeID);
        }
        
    }
}