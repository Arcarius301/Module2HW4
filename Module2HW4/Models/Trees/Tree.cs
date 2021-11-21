using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models.Enumerations;

namespace Module2HW4.Models.Trees
{
    public abstract class Tree : Plant
    {
        public Tree()
        {
            Stem = Stem.Woody;
        }

        public int GrowthRingCount { get; set; }
    }
}
