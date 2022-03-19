using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Derivco_Roulette.Models
{
    public class WheelNumber
    {


        public int Number { get; }

        public WheelNumberColourEnum Colour { get; }

        public WheelNumber(int number, WheelNumberColourEnum colour)
        {
            Number = number;
            Colour = colour;
        }

    }
}
