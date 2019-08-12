using JsonToJsonCompareEngine.UI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JsonToJsonCompareEngine.UI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<State> States { get; set; }
        public DbSet<County> Counties { get; set; }

    }
}
