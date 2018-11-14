using System;
using System.Text;
using Underflow.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Underflow.data
{

        public class ApplicationDbContext : DbContext
        {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

       
    }
}



 
    