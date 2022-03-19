using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivco_Roulette.Models
{
    
    public class WinningNumber
    {
        public int Id { get; set; }
        public int Number { get; set; }

        public string Color { get; set; }

    }
}
