using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WritingIdeas.Model;

namespace WritingIdeas.Persistence
{
    public class SuggestionDbContext : DbContext
    {

        public SuggestionDbContext() : base("dbContext")
        {
        }

        public DbSet<Suggestion> Suggestion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
