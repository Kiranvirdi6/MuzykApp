using Microsoft.EntityFrameworkCore;
using MuzykApp.API.Models;

namespace MuzykApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Values> Values{get; set;}
    }
}