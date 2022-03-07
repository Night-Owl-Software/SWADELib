using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWADELib
{
    public abstract class SWADETrait
    {
        public Guid ID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
