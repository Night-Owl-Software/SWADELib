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

        public override string ToString()
        {
            return $"{Trait.Name} [{TraitDie}]";
        }
    }
}
