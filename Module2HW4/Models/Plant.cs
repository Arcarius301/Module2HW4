using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module2HW4.Models.Enumerations;

namespace Module2HW4.Models
{
    public abstract class Plant
    {
        public string Name { get; set; }
        public bool IsEvergreen { get; set; }
        public int Lifespan { get; set; }
        public Stem Stem { get; set; }
    }
}
