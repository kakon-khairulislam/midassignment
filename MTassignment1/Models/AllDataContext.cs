using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MTassignment1.Models
{
    public class AllDataContext:DbContext
    {
        public DbSet<AllData> AllDatas { get; set; }
    }
}
