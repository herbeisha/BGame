using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace BGame.Models
{
    public class BGameDbContext: DbContext
    {
        public BGameDbContext(DbContextOptions<BGameDbContext> options) : base(options) { }

        public DbSet<GameItem> GameItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
