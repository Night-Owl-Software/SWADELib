namespace SWADELib
{
    public class SWADESkill : SWADETrait
    {
        public SWADEAttribute Attribute { get; set; }

        public SWADESkill(string name, string description, SWADEAttribute attribute)
        {
            Name = name;
            Description = description;
            Attribute = attribute;
        }

        public override string ToString()
        {
            return $"{Name} ({Attribute.Name})";
        }
    }
}
