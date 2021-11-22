using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models;

namespace Module2HW4.Services.Abstractions
{
    public interface IFenceService
    {
        bool Add(Plant item);
        Plant[] Get();
        void Clean();
        int CountSpecies();
        bool Sort();
    }
}
