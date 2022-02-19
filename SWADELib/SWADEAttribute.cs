namespace SWADELib
{
    public class SWADEAttribute : SWADETrait
    {
        public SWADEAttribute(string name, string description, Die die, Die wildDie)
        {
            Name = name;
            Description = description;
            Die = die;
            WildDie = wildDie;
        }

        public override string ToString()
        {
            return $"{Name} [{Die}]";
        }
    }
}
