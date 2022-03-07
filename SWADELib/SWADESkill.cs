namespace SWADELib
{
    public class SWADESkill : SWADETrait
    {
        public SWADEAttribute Attribute { get; set; }
        public bool IsCoreSkill { get; set; }

        public SWADESkill(Guid id, string name, string description, SWADEAttribute attribute, bool coreSkill)
        {
            ID = id;
            Name = name;
            Description = description;
            Attribute = attribute;
            IsCoreSkill = coreSkill;
        }

        public override string ToString()
        {
            return $"{Name} ({Attribute.Name})";
        }
    }
}
