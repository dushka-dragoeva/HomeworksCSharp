namespace ClassChefInCSharp
{
    using System;
    
    public class Chef
    {
        public Bowl Cook()
        {
            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);

            Bowl bowl = this.GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);

            return bowl;
        }

        public Bowl Cook(Vegetable vegetable)
        {
            Bowl bowl = this.GetBowl();
            bowl.Add(vegetable);

            return bowl;
        }

        public Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable vegitable)
        {
            vegitable.IsPeeled = true;
        }

        private void Cut(Vegetable vegitable)
        {
            vegitable.IsCutted = true;
        }
    }
}