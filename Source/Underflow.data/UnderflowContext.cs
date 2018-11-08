using System;
using Microsoft.EntityFrameworkCore;
using Underflow.Entity;

namespace Underflow.data
{
    public class UnderflowContext : DbContext
    {
        public DbSet<Questions> Questions { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }




    }
}
