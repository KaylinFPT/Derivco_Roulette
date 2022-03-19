using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Derivco_Roulette.Models
{
    public class Wheel
    {

        public static readonly WheelNumber[] WheelNumbers =
        {
            new WheelNumber(0, WheelNumberColourEnum.GREEN),
            new WheelNumber(32, WheelNumberColourEnum.RED),
            new WheelNumber(15, WheelNumberColourEnum.BLACK),
            new WheelNumber(19, WheelNumberColourEnum.RED),
            new WheelNumber(4, WheelNumberColourEnum.BLACK),
            new WheelNumber(21, WheelNumberColourEnum.RED),
            new WheelNumber(2, WheelNumberColourEnum.BLACK),
            new WheelNumber(25, WheelNumberColourEnum.RED),
            new WheelNumber(17, WheelNumberColourEnum.BLACK),
            new WheelNumber(34, WheelNumberColourEnum.RED),
            new WheelNumber(6, WheelNumberColourEnum.BLACK),
            new WheelNumber(27, WheelNumberColourEnum.RED),
            new WheelNumber(13, WheelNumberColourEnum.BLACK),
            new WheelNumber(36, WheelNumberColourEnum.RED),
            new WheelNumber(11, WheelNumberColourEnum.BLACK),
            new WheelNumber(30, WheelNumberColourEnum.RED),
            new WheelNumber(8, WheelNumberColourEnum.BLACK),
            new WheelNumber(23, WheelNumberColourEnum.RED),
            new WheelNumber(10, WheelNumberColourEnum.BLACK),
            new WheelNumber(5, WheelNumberColourEnum.RED),
            new WheelNumber(24, WheelNumberColourEnum.BLACK),
            new WheelNumber(16, WheelNumberColourEnum.RED),
            new WheelNumber(33, WheelNumberColourEnum.BLACK),
            new WheelNumber(1, WheelNumberColourEnum.RED),
            new WheelNumber(20, WheelNumberColourEnum.BLACK),
            new WheelNumber(14, WheelNumberColourEnum.RED),
            new WheelNumber(31, WheelNumberColourEnum.BLACK),
            new WheelNumber(9, WheelNumberColourEnum.RED),
            new WheelNumber(22, WheelNumberColourEnum.BLACK),
            new WheelNumber(18, WheelNumberColourEnum.RED),
            new WheelNumber(29, WheelNumberColourEnum.BLACK),
            new WheelNumber(7, WheelNumberColourEnum.RED),
            new WheelNumber(28, WheelNumberColourEnum.BLACK),
            new WheelNumber(12, WheelNumberColourEnum.RED),
            new WheelNumber(35, WheelNumberColourEnum.BLACK),
            new WheelNumber(3, WheelNumberColourEnum.RED),
            new WheelNumber(26, WheelNumberColourEnum.BLACK)
        };




    }
}
