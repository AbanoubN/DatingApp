using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DattingAppf.Models;
using java.lang.reflect;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace DattingAppf.Data
{
    public class DataContext :DbContext 
    {
        public DataContext (DbContextOptions <DataContext> options ) :base (options)
        {

        }

        public DbSet<Value> Values { get; set; }

    }
}
