namespace SWADELib
{
    public class Die
    {
        public int Faces
        {
            get;
            set;
        }

        public Die(int faces)
        {
            Faces = faces;
        }

        public int Roll()
        {
            Random rand = new Random();
            return rand.Next(1, Faces + 1);
        }

        public int[] RollWithExplosions()
        {
            List<int> rolls = new List<int>();

            do
            {
                int roll = Roll();
                rolls.Add(roll);
            } while (roll == Faces);

            return rolls.ToArray();
        }

        public override string ToString()
        {
            return $"d{Faces}";
        }
    }
}
