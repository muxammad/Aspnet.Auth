using Auth.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Auth.Web.DataAccess;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public virtual DbSet<User> Users { get; set; }
    
}