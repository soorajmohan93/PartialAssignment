using System;
using System.Collections.Generic;

namespace PartialForPlanets.Models
{
    public class Planets
    {
        public String Name { get; set; }

        public String Description { get; set; }

        public int Position { get; set; }

        public decimal Size { get; set; }

        public List<String> Features { get; set; }

        public Planets()
        {
        }
    }
}
