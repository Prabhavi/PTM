using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrackerModule.Models;

namespace TrackerModule.Context
{
    public class projectContext: DbContext
    {
        public DbSet<project> projects { get; set; }
        public DbSet<user> users { get; set; }

    }
}