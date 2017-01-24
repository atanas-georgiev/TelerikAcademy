using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task01_Towns.Data
{
    public class Continent
    {
        public int Id { get; set; }

        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
    }
}