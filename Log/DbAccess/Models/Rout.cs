using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbAccess.Models
{
    public class Rout
    {
        public int Id { get; set; }
        [ForeignKey("StartCity")]
        public int StartCityId { get; set; }
        [ForeignKey("EndCity")]
        public int EndCityId { get; set; }
        public DateTime DateUpdated { get; set; }
        public decimal Distance { get; set; }

        public City StartCity { get; set; }
        public City EndCity { get; set; }
    }
}
