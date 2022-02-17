namespace SWADELib
{
    public class SWADESkill
    {
        public string Name { get; set; }
        public SWADEAttribute Attribute { get; set; }
        public Die Die { get; set; }

        public SWADESkill(string name, SWADEAttribute attribute, Die die)
        {
            Name = name;
            Attribute = attribute;
            Die = die;
        }

        public override string ToString()
        {
            return $"{Name} ({Attribute.Name}) [{Die}]";
        }
    }
}
