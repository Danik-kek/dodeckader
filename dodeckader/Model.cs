using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dodeckader
{        class Model
        {
            Point3D[] points;
            Point3D[] dodechaedr3D = new Point3D[20];
            int[,] DodecIndex ={
                           { 0,  1,  9, 16,  5},
                           { 1,  0,  3, 18,  7},
                           { 1,  7, 11, 10,  9},
                           {11,  7, 18, 19,  6},
                           { 8, 17, 16,  9, 10},
                           { 2, 14, 15,  6, 19},
                           { 2, 13, 12,  4, 14},
                           { 2, 19, 18,  3, 13},
                           { 3,  0,  5, 12, 13},
                           { 6, 15,  8, 10, 11},
                           { 4, 17,  8, 15, 14},
                           { 4, 12,  5, 16, 17} };
            private void InitDodechaedr(int[,] Index, Point3D[] points, int Size)
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Index[i, j] = DodecIndex[i, j];
                    }
                }
                double alpha = Math.Sqrt(2.0 / (3.0 + Math.Sqrt(5.0)));
                double beta = 1.0 + Math.Sqrt(6.0 / (3.0 + Math.Sqrt(5.0)) -
                    2.0 + 2.0 * Math.Sqrt(2.0 / (3.0 + Math.Sqrt(5.0))));
                dodechaedr3D[0] = new Point3D(-alpha * Size, 0, beta * Size);
                dodechaedr3D[1] = new Point3D(alpha * Size, 0, beta * Size);
                dodechaedr3D[2] = new Point3D(-1 * Size, -1 * Size, -1 * Size);
                dodechaedr3D[3] = new Point3D(-1 * Size, -1 * Size, 1 * Size);
                dodechaedr3D[4] = new Point3D(-1 * Size, 1 * Size, -1 * Size);
                dodechaedr3D[5] = new Point3D(-1 * Size, 1 * Size, 1 * Size);
                dodechaedr3D[6] = new Point3D(1 * Size, -1 * Size, -1 * Size);
                dodechaedr3D[7] = new Point3D(1 * Size, -1 * Size, 1 * Size);
                dodechaedr3D[8] = new Point3D(1 * Size, 1 * Size, -1 * Size);
                dodechaedr3D[9] = new Point3D(1 * Size, 1 * Size, 1 * Size);
                dodechaedr3D[10] = new Point3D(beta * Size, alpha * Size, 0);
                dodechaedr3D[11] = new Point3D(beta * Size, -alpha * Size, 0);
                dodechaedr3D[12] = new Point3D(-beta * Size, alpha * Size, 0);
                dodechaedr3D[13] = new Point3D(-beta * Size, -alpha * Size, 0);
                dodechaedr3D[14] = new Point3D(-alpha * Size, 0, -beta * Size);
                dodechaedr3D[15] = new Point3D(alpha * Size, 0, -beta * Size);
                dodechaedr3D[16] = new Point3D(0, beta * Size, alpha * Size);
                dodechaedr3D[17] = new Point3D(0, beta * Size, -alpha * Size);
                dodechaedr3D[18] = new Point3D(0, -beta * Size, alpha * Size);
                dodechaedr3D[19] = new Point3D(0, -beta * Size, -alpha * Size);
                for (int i = 0; i < 20; i++)
                {
                    points[i] = dodechaedr3D[i];
                }
            }
            public Model(int countVertex, int[,] Index, Point3D[] Vertex, int Size)
            {
                switch (countVertex)
                {
                    case 20: // Додекаэдр
                        points = new Point3D[20];
                        InitDodechaedr(Index, Vertex, Size);
                        break;
                    default:
                        break;
                }
            }
        }
    }
