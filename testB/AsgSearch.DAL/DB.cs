using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AsgSearch.DAL
{
    public class DB : DbContext
    {

        
        public DB() : base("ASGsearchDB") { Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DB>()); }
        public DbSet<Query> Queries { get; set; }
        public DbSet<SearchResult> SearchResults { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<Query>().HasMany<SearchResult>(key => key.SearchResults)
                    .WithMany()
                    .Map(m =>
                    {
                        m.ToTable("SearchResults");
                    });
        }


    }
}
