using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsgSearch.DAL
{
    [Table("SearchResult")]
    public class SearchResult
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string OwnerName { get; set; }
        public int? AcceptedAnsId { get; set; }
        public string AcceptedAns { get; set; }
        public string Avatar { get; set; }
        public string Tags { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
