using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Box
    {
        public int BoxNumber { get; set; }
        public float BoxWeightContent { get; set; }
        public Color SmartiesColor { get; set; }

        public Box(int boxnumber, float boxweightcontent, Color smartiescolor)
        {
            BoxNumber = boxnumber;
            BoxWeightContent = boxweightcontent;
            SmartiesColor = smartiescolor;
        }
    }
}
