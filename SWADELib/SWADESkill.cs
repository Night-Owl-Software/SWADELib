namespace SWADELib
{
    public class SWADESkill : SWADETrait
    {
        public SWADEAttribute Attribute { get; set; }

        public SWADESkill(string name, string description, SWADEAttribute attribute, Die die, Die wildDie)
        {
            Name = name;
            Description = description;
            Attribute = attribute;
            Die = die;
            WildDie = wildDie;
        }

        public override string ToString()
        {
            return $"{Name} ({Attribute.Name}) [{Die}]";
        }
    }
}
