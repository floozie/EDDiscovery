using System;

namespace ProtoShared
{
    public class Coords
    {
        public double X;
        public double Y;
        public double Z;

        public Coords()
        {

        }
        public Coords(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double this[int key]
        {
            get => getKey(key);
            set => setKey(key, value);
        }

        private double getKey(int key)
        {
            switch (key)
            {
                case 0: return X;
                case 1: return Y;
                case 2: return Z;

            }
            return 0.0;
        }

        private void setKey(int key, double value)
        {
            switch (key)
            {
                case 0: X = value; break;
                case 1: Y = value; break;
                case 2: Z = value; break;

            }

        }

    }
}
