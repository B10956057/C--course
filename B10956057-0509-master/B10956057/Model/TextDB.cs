using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace B10956057.Model
{
    public class TextDB : DbContext
    {
        public TextDB(DbContextOptions<TextDB> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
