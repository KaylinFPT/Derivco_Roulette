using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivco_Roulette.Models
{
    public class Bet
    {

        public int Id { get; set; }

        public string Type { get; set; }

        public int Amount { get; set; }

        public int? Number { get; set; }

    }
}
