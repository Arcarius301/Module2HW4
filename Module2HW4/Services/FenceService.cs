using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;
using Module2HW4.Services.Abstractions;
using Module2HW4.Providers.Abstractions;

namespace Module2HW4.Services
{
    public class FenceService : IFenceService
    {
        private readonly IPlantProvider _plantProvider;
        private Plant[] _plants;

        public FenceService(IPlantProvider plantProvider)
        {
            _plantProvider = plantProvider;
            _plants = _plantProvider.Get();
        }

        public bool Add(Plant item)
        {
            if (_plants == null)
            {
                _plants = new Plant[1];
                _plants[0] = item;
            }
            else
            {
                Array.Resize(ref _plants, _plants.Length + 1);
                _plants[_plants.Length - 1] = item;
            }

            return true;
        }

        public Plant[] Get()
        {
            var plants = new Plant[_plants.Length];

            for (var i = 0; i < _plants.Length; i++)
            {
                _plants[i] = _plants[i];
            }

            return _plants;
        }

        public void Clean()
        {
            _plants = new Plant[0];
        }

        public int CountSpecies()
        {
            var species = 0;
            var plants = new string[_plants.Length];

            for (var i = 0; i < plants.Length; i++)
            {
                plants[i] = _plants[i].Name;
            }

            for (var i = 0; i < plants.Length; i++)
            {
                if (plants[i].Equals(string.Empty))
                {
                    continue;
                }

                for (var j = 0; j < plants.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (plants[i].Equals(plants[j]))
                    {
                        plants[j] = string.Empty;
                    }
                }
            }

            for (var i = 0; i < plants.Length; i++)
            {
                if (!plants[i].Equals(string.Empty))
                {
                    species++;
                }
            }

            return species;
        }

        public bool Sort()
        {
            if (_plants.Length <= 1)
            {
                return false;
            }

            Array.Sort(_plants, new PlantComparer());

            return true;
        }
    }
}
