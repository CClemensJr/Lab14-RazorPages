using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetAGram.Data
{
    public class DotNetAGramDbContext : DbContext
    {
        /// <summary>
        /// This constructor method brings in the DbContext options
        /// </summary>
        /// <param name="options"></param>
        public DotNetAGramDbContext(DbContextOptions<DotNetAGramDbContext> options) : base(options) { }

        /// <summary>
        /// This method allows the DbContext to build model objects to seed the db
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
