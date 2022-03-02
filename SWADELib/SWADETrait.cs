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

        public int[][] RollAsWildCard()
        {
            if(Die == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            if(WildDie == null)
            {
                throw new SWADEMissingObjectException("Trait Wild Die Object is NULL");
            }

            int[][] results = new int[2][];
            results[0] = Die.RollWithExplosions();
            results[1] = WildDie.RollWithExplosions();
            return results;
        }

        public int[] RollAsExtra()
        {
            if (Die == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            return Die.RollWithExplosions();
        }
    }
}
