namespace SWADELib
{
    public class SWADEAttribute
    {
        public string Name;
        public Die Die;

        public SWADEAttribute(string name, Die die)
        {
            Name = name;
            Die = die;
        }

        public override string ToString()
        {
            return $"{Name} [{Die}]";
        }
    }
}
