using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace practicescaf.Models
{
    public class Teams
    {
        [Key]
        public int Teamid { get; set; }

        public string TeamName { get; set; }

        public int Record { get; set; }
    }
}
