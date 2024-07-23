using BlazorCrudWasm.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrudWasm.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame { Id = 1, Title = "CyberPunk 2077", Publisher = "CD Project", ReleaseYear = 2024 },
                new VideoGame { Id = 2, Title = "Elden Ring", Publisher = "From Software", ReleaseYear = 2020 },
                new VideoGame { Id = 3, Title = "The lengend of Zelda: Ocarina of Time", Publisher = "Nintendo", ReleaseYear = 1998 }
                );
        }

        public DbSet<VideoGame> VideoGames { get; set; }
    }
}
