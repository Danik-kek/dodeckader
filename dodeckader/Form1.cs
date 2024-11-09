using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace dodeckader
{
    public partial class Form1 : Form
    {
        Graphics drawarea;
        Pen DotPen = new Pen(Color.Gray, 1);
        Pen MainPen = new Pen(Color.Black, 1);
        // Init dodec
        int[,] DodecIndex = new int[20, 5];
        Model dodechaedr;
        Point3D[] dodechaedr3D = new Point3D[20];
        Point3D[] dodechaedr3Dcopy = new Point3D[20];
        Point3D[] dodechaedr3Dmem = new Point3D[20];
        Point3D[] dodechaedr2D = new Point3D[20];
        public Form1()
        {
            InitializeComponent();
            drawarea = pictureBox1.CreateGraphics();
            DotPen.DashStyle = DashStyle.Dash;
            DotPen.DashPattern = new float[] { 5.0F, 5.0F, 5.0F, 5.0F };
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
            {
                drawarea.Clear(Color.White);
                /////////////
                dodechaedr = new Model(20, DodecIndex, dodechaedr3D, Convert.ToInt32(textBox3.Text));
                for (int i = 0; i < 20; i++)
                {
                    dodechaedr2D[i] = new Point3D(0, 0, 0);
                    dodechaedr3D[i].x *= 50;
                    dodechaedr3D[i].y *= 50;
                    dodechaedr3D[i].z *= 50;
                    dodechaedr3Dcopy[i] = new Point3D(0, 0, 0);
                    dodechaedr3Dmem[i] = new Point3D(0, 0, 0);
                }
                dodechaedr = new Model(20, DodecIndex, dodechaedr3D, Convert.ToInt32(textBox3.Text));
                Controller.RotateX(dodechaedr3D, dodechaedr3Dmem, Convert.ToInt32(textBox1.Text));
                dodechaedr3Dcopy = dodechaedr3Dmem;
                Controller.RotateY(dodechaedr3Dcopy, dodechaedr3Dmem, Convert.ToInt32(textBox2.Text));
                dodechaedr3Dcopy = dodechaedr3Dmem;
                Controller.Transform(dodechaedr3Dcopy, dodechaedr3Dmem, new Point3D(Convert.ToInt32(textBox6.Text),
    Convert.ToInt32(textBox7.Text), 0));
                dodechaedr3Dcopy = dodechaedr3Dmem;
                Controller.Multi(dodechaedr3Dcopy, dodechaedr2D);
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (Controller.MultiVector(Controller.GetVector(dodechaedr3Dcopy[DodecIndex[i, 0]], dodechaedr3Dcopy[DodecIndex[i,
    4]]),
                                                   Controller.GetVector(dodechaedr3Dcopy[DodecIndex[i, 0]], dodechaedr3Dcopy[DodecIndex[i, 1]])).z > 0)
                        {
                            if (j == 4)
                            {
                                drawarea.DrawLine(MainPen, (int)dodechaedr2D[DodecIndex[i, j]].x, (int)dodechaedr2D[DodecIndex[i, j]].y,
    (int)dodechaedr2D[DodecIndex[i, 0]].x, (int)dodechaedr2D[DodecIndex[i, 0]].y);
                                break;
                            }
                            drawarea.DrawLine(MainPen, (int)dodechaedr2D[DodecIndex[i, j]].x, (int)dodechaedr2D[DodecIndex[i, j]].y,
    (int)dodechaedr2D[DodecIndex[i, j + 1]].x, (int)dodechaedr2D[DodecIndex[i, j + 1]].y);
                        }
                        else
                        {
                            if (j == 4)
                            {
                                drawarea.DrawLine(DotPen, (int)dodechaedr2D[DodecIndex[i, j]].x, (int)dodechaedr2D[DodecIndex[i, j]].y,
    (int)dodechaedr2D[DodecIndex[i, 0]].x, (int)dodechaedr2D[DodecIndex[i, 0]].y);
                                break;
                            }
                            drawarea.DrawLine(DotPen, (int)dodechaedr2D[DodecIndex[i, j]].x, (int)dodechaedr2D[DodecIndex[i, j]].y,
    (int)dodechaedr2D[DodecIndex[i, j + 1]].x, (int)dodechaedr2D[DodecIndex[i, j + 1]].y);
                        }
                    }
                }
                if (radioButton1.Checked)
                {
                    Brush brush = new SolidBrush(Color.Red);
                    Point[] points = new Point[5];
                    int r = 125;
                    for (int i = 0; i < 12; i++)
                    {
                        if (Controller.MultiVector(Controller.GetVector(dodechaedr3Dcopy[DodecIndex[i, 0]], dodechaedr3Dcopy[DodecIndex[i,
    4]]),
                                                       Controller.GetVector(dodechaedr3Dcopy[DodecIndex[i, 0]], dodechaedr3Dcopy[DodecIndex[i, 1]])).z >
    0)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                points[j] = new Point((int)dodechaedr2D[DodecIndex[i, j]].x, (int)dodechaedr2D[DodecIndex[i, j]].y);
                            }
                            drawarea.FillPolygon(brush, points);
                            brush = new SolidBrush(Color.FromArgb(r % 223, 160, 171));
                            r += 32;
                        }
                    }
                }
            }

        }
    }

