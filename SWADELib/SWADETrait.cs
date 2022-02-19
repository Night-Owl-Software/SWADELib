using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWADELib
{
    public abstract class SWADETrait
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Die? Die { get; set; }
        public Die? WildDie { get; set; }

        public int[] RollWildCardAttribute()
        {
            if(Die == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            if(WildDie == null)
            {
                throw new SWADEMissingObjectException("Trait Wild Die Object is NULL");
            }

            int[] results = new int[2];
            results[0] = Die.Roll();
            results[1] = WildDie.Roll();
            return results;
        }

        public int RollExtraAttribute()
        {
            if (Die == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            return Die.Roll();
        }
    }
}
