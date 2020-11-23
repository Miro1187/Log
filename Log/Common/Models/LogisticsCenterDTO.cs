using System;
using System.Collections.Generic;
using System.Text;

namespace DbAccess.Models
{
    public class LogisticsCenterDTO
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
