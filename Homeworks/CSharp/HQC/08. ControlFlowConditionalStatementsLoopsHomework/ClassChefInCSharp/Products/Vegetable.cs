namespace ClassChefInCSharp
{
    using System;

    public abstract class Vegetable
    {
        public Vegetable()
        {
            this.IsRotten = false;
            this.IsPeeled = false;
            this.IsCutted = false;
        }

        public bool IsRotten { get; set; }

        public bool IsPeeled { get; set; }

        public bool IsCutted { get; set; }
    }
}
