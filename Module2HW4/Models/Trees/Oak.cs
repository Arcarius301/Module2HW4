using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models.Enumerations;

namespace Module2HW4.Models.Trees
{
    public class Oak : DeciduousTree
    {
        public Oak()
        {
            Name = "Oak";
            Lifespan = 200;
            DeciduousSeason = Season.Autumn;
        }
    }
}
