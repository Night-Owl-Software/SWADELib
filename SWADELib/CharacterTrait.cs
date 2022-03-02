using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWADELib
{
    public class CharacterTrait
    {
        public SWADETrait Trait { get; set; }
        public Die TraitDie { get; set; }
        public Die WildDie { get; set; }

        public CharacterTrait(SWADETrait trait, Die traitDie, Die wildDie)
        {
            Trait = trait;
            TraitDie = traitDie;
            WildDie = wildDie;
        }

        public int[][] RollAsWildCard()
        {
            if (TraitDie == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            if (WildDie == null)
            {
                throw new SWADEMissingObjectException("Trait Wild Die Object is NULL");
            }

            int[][] results = new int[2][];
            results[0] = TraitDie.RollWithExplosions();
            results[1] = WildDie.RollWithExplosions();
            return results;
        }

        public int[] RollAsExtra()
        {
            if (TraitDie == null)
            {
                throw new SWADEMissingObjectException("Trait Die Object is NULL");
            }

            return TraitDie.RollWithExplosions();
        }

        public override string ToString()
        {
            return $"{Trait.Name} [{TraitDie}]";
        }
    }
}
