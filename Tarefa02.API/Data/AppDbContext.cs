using Tarefa02.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Tarefa02.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto>? Produto {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");
    }
}