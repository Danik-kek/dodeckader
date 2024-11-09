using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodeckader
{
    internal class Controller
    {
        public static void Multi(Point3D[] mass, Point3D[] mass2)
        {
            int n = mass.Length;
            for (int i = 0; i < n; i++)
            {
                mass2[i].x = mass[i].x / mass[i].p;
                mass2[i].y = mass[i].y / mass[i].p;
            }
        }
        public static Point3D MultiVector(Point3D a, Point3D b)
        {
            Point3D c = new Point3D(0, 0, 0);
            c.x = -a.z * b.y + a.y * b.z;
            c.y = a.z * b.x - a.x * b.z;
            c.z = -a.y * b.x + a.x * b.y;
            return c;
        }
        public static Point3D GetVector(Point3D p1, Point3D p2)
        {
            return new Point3D(p2.x - p1.x, p2.y - p1.y, p2.z - p1.z);
        }
        public static void RotateX(Point3D[] mass, Point3D[] mass2, double Angle)
        {
            int n = mass.Length;
            for (int i = 0; i < n; i++)
            {
                mass2[i].x = mass[i].x;
                mass2[i].y = Math.Cos(Angle) * mass[i].y - Math.Sin(Angle) * mass[i].z;
                mass2[i].z = Math.Sin(Angle) * mass[i].y + Math.Cos(Angle) * mass[i].z;
            }
        }
        public static void RotateY(Point3D[] mass, Point3D[] mass2, double Angle)
        {
            int n = mass.Length;
            for (int i = 0; i < n; i++)
            {
                mass2[i].x = Math.Cos(Angle) * mass[i].x + Math.Sin(Angle) * mass[i].z;
                mass2[i].y = mass[i].y;
                mass2[i].z = -Math.Sin(Angle) * mass[i].x + Math.Cos(Angle) * mass[i].z;
            }
        }
        public static void RotateZ(Point3D[] mass, Point3D[] mass2, double Angle)
        {
            int n = mass.Length;
            for (int i = 0; i < n; i++)
            {
                mass2[i].x = Math.Cos(Angle) * mass[i].x - Math.Sin(Angle) * mass[i].y;
                mass2[i].y = Math.Sin(Angle) * mass[i].x + Math.Cos(Angle) * mass[i].y;
                mass2[i].z = mass[i].z;
            }
        }
        public static void Transform(Point3D[] mainMatrix, Point3D[] resultMatrix, Point3D transformVector)
        {
            for (int i = 0; i < mainMatrix.Length; i++)
            {
                resultMatrix[i].x = mainMatrix[i].x + mainMatrix[i].p * transformVector.x;
                resultMatrix[i].y = mainMatrix[i].y + mainMatrix[i].p * transformVector.y;
                resultMatrix[i].z = mainMatrix[i].z + mainMatrix[i].p * transformVector.z;
            }
        }
    }
}

