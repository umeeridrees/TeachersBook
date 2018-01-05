using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class FYPDbContext : DbContext
    {
        public FYPDbContext() : base("FYP")
        {

        } 

        public DbSet<Rating> Ratings { get; set; }
    }
}
