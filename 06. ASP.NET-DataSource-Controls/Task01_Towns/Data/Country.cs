using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task01_Towns.Data
{
    public class Country
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(200)]
        public string Name { get; set; }

        [MinLength(2)]
        [MaxLength(200)]
        public string Language { get; set; }

        public byte[] Flag { get; set; }
        public int Population { get; set; }
        public int ContinentId { get; set; }
        public virtual Continent Continent { get; set; }
    }
}