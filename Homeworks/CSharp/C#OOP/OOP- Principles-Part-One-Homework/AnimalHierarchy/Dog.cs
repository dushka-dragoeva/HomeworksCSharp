namespace AnimalHierarchy
{
   public class Dog : Animal, ISound
    {

        public Dog(int age, string name, Gender gender)
            : base(age, name, gender)
        {
        }

        public override string MySound()
        {
            return "Baw! Baw! Baw!";
        }
    }
}
