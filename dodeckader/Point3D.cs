using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodeckader
{
    internal class Point3D
    {
        double X;
        double Y;
        double Z;
        int P = 1;
        public double x
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }
        public double y
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }
        public double z
        {
            get
            {
                return Z;
            }
            set
            {
                Z = value;
            }
        }
        public int p
        {
            get { return P; }
            set { }
        }
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
