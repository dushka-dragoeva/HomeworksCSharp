// 2Task
namespace MagicHeros
{
    internal class MagicHero
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        internal static void CreateHero(int magicNumber)
        {
            MagicHero currentHero = new MagicHero();
            currentHero.Age = magicNumber;
            if (magicNumber % 2 == 0)
            {
               currentHero.Name = "Bro";
               currentHero.Gender = Gender.male;
            }
            else
            {
               currentHero.Name = "Pussycat";
               currentHero.Gender = Gender.female;
            }
        }
    }
}