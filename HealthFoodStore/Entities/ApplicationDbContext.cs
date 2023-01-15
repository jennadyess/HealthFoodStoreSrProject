using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthFoodStore.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthFoodStore.Entities
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
