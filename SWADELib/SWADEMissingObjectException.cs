using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWADELib
{
    public class SWADEMissingObjectException : Exception
    {
        public SWADEMissingObjectException() : base("Missing SWADE Object") { }

        public SWADEMissingObjectException(string message) : base(message) { }
    }
}
