using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models.Enumerations;

namespace Module2HW4.Models.Trees
{
    public abstract class DeciduousTree : Tree
    {
        public Season DeciduousSeason { get; set; }
    }
}
