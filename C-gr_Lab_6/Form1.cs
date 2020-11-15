using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace C_gr_Lab_6
{
    public partial class Form1 : Form
    { // Size: 1 000, 600
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region // кисти
            Graphics g = e.Graphics;
            SolidBrush sun = new SolidBrush(Color.Yellow);
            SolidBrush clouds = new SolidBrush(Color.LightGray);
            SolidBrush road = new SolidBrush(Color.DarkSlateGray);
            SolidBrush tile = new SolidBrush(Color.White);
            SolidBrush wheeles = new SolidBrush(Color.Black);
            #endregion

            #region // небо
            g.FillPie(sun, 115, 23, 95, 95, 0, -180);
            g.FillEllipse(clouds, 75, 45, 155, 75);
            g.FillEllipse(clouds, 250, 20, 130, 45);
            g.FillEllipse(clouds, 432, 55, 180, 80);
            g.FillEllipse(clouds, 650, 25, 130, 70);
            g.FillEllipse(clouds, -50, 35, 100, 70);
            #endregion

            #region // Машины
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Point[] truck1 = new Point[4] {new Point(500, this.ClientRectangle.Width), new Point(500, 350), new Point(300, 350),
                new Point(300, this.ClientRectangle.Height - 75) };
            Point[] truck2 = new Point[4] {new Point(575, this.ClientRectangle.Width/2), new Point(575, 425), new Point(500, 425),
                new Point(500, this.ClientRectangle.Height - 75) };
            Point[] car1 = new Point[4] {new Point(400, this.ClientRectangle.Width), new Point(400, 410), new Point(200, 410),
                new Point(200, this.ClientRectangle.Height - 75) };
            Point[] car2 = new Point[4] {new Point(400, this.ClientRectangle.Width/2), new Point(400, 450), new Point(450, 450),
                new Point(450, this.ClientRectangle.Height - 75) };
            Point[] car3 = new Point[4] {new Point(150, this.ClientRectangle.Width/2), new Point(150, 450), new Point(200, 450),
                new Point(200, this.ClientRectangle.Height - 75) };
            g.FillPolygon(Brushes.LightGray, truck1);
            g.DrawPolygon(Pens.Black, truck1);
            g.FillPolygon(Brushes.LightBlue, truck2);
            g.DrawPolygon(Pens.Black, truck2);
            g.FillPolygon(Brushes.Red, car1);
            g.DrawPolygon(Pens.Black, car1);
            g.FillPolygon(Brushes.Red, car2);
            g.DrawPolygon(Pens.Black, car2);
            g.FillPolygon(Brushes.Red, car3);
            g.DrawPolygon(Pens.Black, car3);

            g.FillRectangle(Brushes.Gray, this.ClientRectangle.Width - 150, 170, 500, 500);
            g.DrawRectangle(Pens.Black, this.ClientRectangle.Width - 150, 170, 500, 500);

            g.FillRectangle(Brushes.DarkGray, this.ClientRectangle.Width - 200, 225, 500, 500);
            g.DrawRectangle(Pens.Black, this.ClientRectangle.Width - 200, 225, 500, 500);
            #endregion

            #region //колеса
            g.FillEllipse(wheeles, 180, 480, 50, 50);
            g.FillEllipse(wheeles, 380, 480, 50, 50);
            g.FillEllipse(wheeles, 500, 480, 50, 50);
            #endregion

            #region // дорога
            Rectangle rectRoad = new Rectangle(-10, this.ClientRectangle.Height - 75,
                this.ClientRectangle.Width + 15, this.ClientRectangle.Height + 15);
            Pen pRoad = new Pen(Brushes.Black, 7);
            g.FillRectangle(road, rectRoad);
            g.DrawRectangle(pRoad, rectRoad);

            Rectangle[] rcs = new Rectangle[11];
            int x = 10;
            for (int i = 0; i < 11; i++)
            {
                rcs[i] = new Rectangle(x, this.ClientRectangle.Height - 40, 50, 15);
                x += 70;

            }

            e.Graphics.FillRectangles(Brushes.White, rcs);
            #endregion
        }
        }
    }