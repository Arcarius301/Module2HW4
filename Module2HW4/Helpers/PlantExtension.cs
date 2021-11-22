using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public static class PlantExtension
    {
        public static Plant[] Find(this Plant[] items, int lifeSpan)
        {
            var plants = new Plant[0];

            for (var i = 0; i < items.Length; i++)
            {
                if (items[i].Lifespan == lifeSpan)
                {
                    if (plants.Length == 0)
                    {
                        plants = new Plant[1];
                        plants[0] = items[i];
                    }
                    else
                    {
                        Array.Resize(ref plants, plants.Length + 1);
                        plants[plants.Length - 1] = items[i];
                    }
                }
            }

            return plants;
        }
    }
}
