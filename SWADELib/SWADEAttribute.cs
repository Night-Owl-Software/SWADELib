namespace SWADELib
{
    public class SWADEAttribute : SWADETrait
    {
        public SWADEAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
