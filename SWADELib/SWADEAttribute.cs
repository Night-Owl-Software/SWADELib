namespace SWADELib
{
    public class SWADEAttribute : SWADETrait
    {
        public SWADEAttribute(Guid id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
