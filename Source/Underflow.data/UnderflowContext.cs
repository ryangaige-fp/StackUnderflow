using System;
using Microsoft.EntityFrameworkCore;
using Underflow.Entity;

namespace Underflow.data
{
    public class UnderflowContext : DbContext
    {
        public DbSet<Questions> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Comments> Comments { get; set; }



        public UnderflowContext(DbContextOptions<UnderflowContext> options) : base(options)
        {


        }




    }
}
