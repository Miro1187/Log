using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DbAccess.Models
{
    public class LogisticsCenter
    {
        public int Id { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public DateTime DateUpdated { get; set; }

        public City City { get; set; }
    }
}
