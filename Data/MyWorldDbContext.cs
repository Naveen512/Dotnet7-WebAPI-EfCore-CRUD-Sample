using dot7.API.Crud.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace dot7.API.Crud.Data;

public class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> context) : base(context)
    {

    }

    public DbSet<Students> Students { get; set; }
}