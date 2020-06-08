using BlogNew1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogNew1.Context
{
    public class ArtykulyContext : DbContext
    {
        public ArtykulyContext() : base("ArtykulyConnectionString")
        { }

       public DbSet<Artykuly> Artykuly { get; set; }
    }
}