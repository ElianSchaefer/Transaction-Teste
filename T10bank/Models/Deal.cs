using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T10bank.Models
{
    public class Deal
    {
        public int DealId { get; set; }

        public string Company { get; set; }

        public double Value { get; set; }

        public DateTime Date { get; set; }
    }
}
