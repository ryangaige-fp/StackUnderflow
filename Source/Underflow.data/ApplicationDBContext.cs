using System;
using System.Text;
using Underflow.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Underflow.data
{

        public class ApplicationDBContext : IdentityDbContext
        {


        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {
        }


    }
    }
}
