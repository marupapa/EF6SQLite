using System;
using EF6SQLite.Models;
using Microsoft.EntityFrameworkCore;

namespace EF6SQLite.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Goods> goodsList => Set<Goods>();
    }
}

