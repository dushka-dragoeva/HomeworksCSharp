namespace _01_04.Structure
{
    using System;
    using System.Text;
    
    public struct Point3D
    {
        private static readonly Point3D o = new Point3D(0, 0, 0);

        public static Point3D O
        {
            get { return o; }
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("X= {0}, Y= {1}, Z= {2}", this.X, this.Y, this.Z));
            return result.ToString();
        }

        public static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }
            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }

}