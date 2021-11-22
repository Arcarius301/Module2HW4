using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Providers.Abstractions;
using Module2HW4.Models.Shrubs;
using Module2HW4.Models.Trees;

namespace Module2HW4.Models.Providers
{
    public class PlantProvider : IPlantProvider
    {
        public Plant[] Get()
        {
            return new Plant[]
                {
                    new Gooseberry(),
                    new Parsley(),
                    new Raspberry(),
                    new Valerian(),
                    new Cedar() { GrowthRingCount = 30 },
                    new Cedar() { GrowthRingCount = 50 },
                    new Maple() { GrowthRingCount = 25 },
                    new Oak() { GrowthRingCount = 40 },
                    new Pine() { GrowthRingCount = 50 }
                };
        }
    }
}
