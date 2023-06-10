using Microsoft.EntityFrameworkCore;
using ModelViewController.Models;

namespace ModelViewController.Context
{
    public class BooknowDbContext : DbContext
    {
        public BooknowDbContext(DbContextOptions<BooknowDbContext> options) : base(options)
        { }
        public DbSet<Booknow> Booknows {get;set;}
    }
}
