using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lesson06___Entity_framework.Models
{
    public class PvvBookStore:DbContext
    {
        public PvvBookStore():base() { }

        public DbSet<PvvCategory> PvvCategories { get; set; }  
        public DbSet<PvvBook> PvvBooks { get; set; }
    }
}