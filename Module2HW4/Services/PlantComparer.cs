using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Services
{
    public class PlantComparer : IComparer<Plant>
    {
        public int Compare(Plant x, Plant y)
        {
            if (x.Lifespan > y.Lifespan)
            {
                return 1;
            }
            else if (x.Lifespan < y.Lifespan)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
