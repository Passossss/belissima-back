using belissima_back.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace belissima_back;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Revendedora> Revendedoras { get; set; }
}
