using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task01_Towns.Data
{
    public class Town
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(200)]
        public string Name { get; set; }

        public int Population { get; set; }
        
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}