using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models.Enumerations;

namespace Module2HW4.Models.Shrubs
{
    public abstract class Shrub : Plant
    {
        public Shrub()
        {
            Stem = Stem.Herbaceous;
        }
    }
}
