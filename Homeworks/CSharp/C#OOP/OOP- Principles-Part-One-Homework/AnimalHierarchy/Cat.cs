namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        public Cat(int age, string name, Gender gender)
            : base(age, name, gender)
        {
        }

        public override string MySound()
        {
            return "Meow! Meow! Meow!";
        }
    }
}
