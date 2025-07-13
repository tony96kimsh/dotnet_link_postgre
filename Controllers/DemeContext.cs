using Microsoft.EntityFrameworkCore;

namespace EfDemoApp.Models
{
  public class DemoContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseNpgsql(
        @"Host=localhost;
        Port=5342;
        Username=postgres;
        Password=post1234;
        Database=postgres");
    }
  }
}