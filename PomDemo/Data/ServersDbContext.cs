using Microsoft.EntityFrameworkCore;
using PomDemo.Models;

namespace PomDemo.Data;

public class ServersDbContext : DbContext
{
    public ServersDbContext(DbContextOptions<ServersDbContext> options)
        : base(options)
    {
    }

    public DbSet<Server> Servers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Server>()
            .HasData(
                new Server { Id = 1, Name = "Server1", City = "Toronto" },
                new Server { Id = 2, Name = "Server2", City = "Toronto" },
                new Server { Id = 3, Name = "Server3", City = "Toronto" },
                new Server { Id = 4, Name = "Server4", City = "Toronto" },
                new Server { Id = 5, Name = "Server5", City = "Montreal" },
                new Server { Id = 6, Name = "Server6", City = "Montreal" },
                new Server { Id = 7, Name = "Server7", City = "Montreal" },
                new Server { Id = 8, Name = "Server8", City = "Ottawa" },
                new Server { Id = 9, Name = "Server9", City = "Ottawa" },
                new Server { Id = 10, Name = "Server10", City = "Calgary" },
                new Server { Id = 11, Name = "Server11", City = "Calgary" },
                new Server { Id = 12, Name = "Server12", City = "Halifax" },
                new Server { Id = 13, Name = "Server13", City = "Halifax" },
                new Server { Id = 14, Name = "Server14", City = "Halifax" },
                new Server { Id = 15, Name = "Server15", City = "Halifax" },
                new Server { Id = 16, Name = "Server16", City = "Halifax" },
                new Server { Id = 17, Name = "Server17", City = "Halifax" },
                new Server { Id = 18, Name = "Server18", City = "Halifax" },
                new Server { Id = 19, Name = "Server19", City = "Halifax" },
                new Server { Id = 20, Name = "Server20", City = "Halifax" },
                new Server { Id = 21, Name = "Server21", City = "Halifax" },
                new Server { Id = 22, Name = "Server22", City = "Halifax" },
                new Server { Id = 23, Name = "Server23", City = "Halifax" },
                new Server { Id = 24, Name = "Server24", City = "Halifax" },
                new Server { Id = 25, Name = "Server25", City = "Halifax" },
                new Server { Id = 26, Name = "Server26", City = "Halifax" },
                new Server { Id = 27, Name = "Server27", City = "Halifax" },
                new Server { Id = 28, Name = "Server28", City = "Halifax" },
                new Server { Id = 29, Name = "Server29", City = "Halifax" },
                new Server { Id = 30, Name = "Server30", City = "Halifax" },
                new Server { Id = 31, Name = "Server31", City = "Halifax" },
                new Server { Id = 32, Name = "Server32", City = "Halifax" },
                new Server { Id = 33, Name = "Server33", City = "Halifax" },
                new Server { Id = 34, Name = "Server34", City = "Halifax" },
                new Server { Id = 35, Name = "Server35", City = "Halifax" },
                new Server { Id = 36, Name = "Server36", City = "Halifax" },
                new Server { Id = 37, Name = "Server37", City = "Halifax" },
                new Server { Id = 38, Name = "Server38", City = "Halifax" },
                new Server { Id = 39, Name = "Server39", City = "Halifax" },
                new Server { Id = 40, Name = "Server40", City = "Halifax" },
                new Server { Id = 41, Name = "Server41", City = "Halifax" },
                new Server { Id = 42, Name = "Server42", City = "Halifax" },
                new Server { Id = 43, Name = "Server43", City = "Halifax" },
                new Server { Id = 44, Name = "Server44", City = "Halifax" },
                new Server { Id = 45, Name = "Server45", City = "Halifax" },
                new Server { Id = 46, Name = "Server46", City = "Halifax" },
                new Server { Id = 47, Name = "Server47", City = "Halifax" },
                new Server { Id = 48, Name = "Server48", City = "Halifax" },
                new Server { Id = 49, Name = "Server49", City = "Halifax" });
    }
}
