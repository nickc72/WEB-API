using Microsoft.EntityFrameworkCore;
using WEB_API.Models;
namespace WEB_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; }
    }
}

//Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;