using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using treinamento.Domain;

namespace treinamento.Repositories
{
    public class AppDbContext : DbContext 
    {
        private readonly DbContext _context;

        public AppDbContext(DbContextOptions<AppDbContext> context): base(context) { }

        public DbSet<TesteDomain> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TesteDomain>(entity =>
            {
                entity.HasKey(u => u.Id); 
            });

        }
    }
}
