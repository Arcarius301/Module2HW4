using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Helpers;
using Module2HW4.Models;
using Module2HW4.Services;
using Module2HW4.Services.Abstractions;

namespace Module2HW4
{
    public class Startup
    {
        private readonly IFenceService _fenceService;

        public Startup(IFenceService fenceService)
        {
            _fenceService = fenceService;
        }

        public void Run()
        {
            var species = _fenceService.CountSpecies();
            _fenceService.Sort();
            var plants = _fenceService.Get().Find(200);
        }
    }
}
