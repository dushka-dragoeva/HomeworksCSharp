namespace AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
        }

        public override string MySound()
        {
            return "Kwa! Kwa! Kwa!";
        }
    }
}

