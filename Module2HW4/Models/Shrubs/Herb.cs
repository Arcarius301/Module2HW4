using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW4.Models.Shrubs
{
    public abstract class Herb : Shrub
    {
        public Herb()
        {
            Lifespan = 1;
        }
    }
}
