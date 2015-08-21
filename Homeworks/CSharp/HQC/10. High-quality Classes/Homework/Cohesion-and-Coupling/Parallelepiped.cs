namespace CohesionAndCoupling
{
    using System;

    internal class Parallelepiped : IDiagonalCalculator
    {
        private double width;
        private double height;
        private double depth;

        public Parallelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.ValidateSite(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.ValidateSite(value);
                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                this.ValidateSite(value);
                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;

            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = DistanceCalculations.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = DistanceCalculations.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = DistanceCalculations.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = DistanceCalculations.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }

        public bool ValidateSite(double number)
        {
            bool isValidSite = number > 0;

            return isValidSite;
        }
    }
}
