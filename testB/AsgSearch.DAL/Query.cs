using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StackExchange.StacMan;
using System.Collections.Generic;

namespace AsgSearch.DAL
{
    [Table("queries")]
    public class Query
    {
        [Key]
        public int ID { get; set; }
        public virtual string QueryText { get; set; }
        public virtual DateTime Time { get; set; }
        public virtual ICollection<SearchResult> SearchResults { get; set; }
        // HINT: You'll have to add some fields here... up to you!

    }

}
