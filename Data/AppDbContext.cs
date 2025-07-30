using System;
using Microsoft.EntityFrameworkCore;

public class AppDbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
	{
		public DbSet<Revendedora> Revendedoras { get; set; }
	}
}
