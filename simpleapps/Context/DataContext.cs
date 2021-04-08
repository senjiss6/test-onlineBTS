using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using simpleapps.Models;

namespace simpleapps.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<shopping> shoppings { get; set; }
    }
}
