using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkers.Models
{
    public class ModelPosition
    {
        public ModelPosition()
        {
        }

        public int[,] Positions { get; set; }
        public int[] Selected { get; set; }
        public bool IsSelect { get; set; }
    }
}
