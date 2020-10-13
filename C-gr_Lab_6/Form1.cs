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
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Задаем красный цвет для носа ракеты
            SolidBrush myNos = new SolidBrush(Color.Red);
            // Задаем серебряный цвет для топливных баков
            SolidBrush myBak = new SolidBrush(Color.Silver);
            // Задаем белый и серый цвет для корпуса ракеты
            SolidBrush myShip = new SolidBrush(Color.White);
            SolidBrush myLine = new SolidBrush(Color.Gray);
            // Задаем желтый и оранжевый цвет для пламени
            SolidBrush myFire1 = new SolidBrush(Color.Yellow);
            SolidBrush myFire2 = new SolidBrush(Color.Orange);
            // Задаем желто-зеленый цвет для звезды
            SolidBrush myStar = new SolidBrush(Color.GreenYellow);
            // ******* 1 - Рисуем топливные баки ************
            // Рисуем два прямоугольника
            g.FillRectangle(myBak, 179, 115, 26, 175);
            g.FillRectangle(myBak, 275, 115, 26, 175);
            // Сверху каждого прямоугольника рисуем по треугольнику
            g.FillPolygon(myBak, new Point[] {

new Point(179,115),new Point(192,100),
new Point(192,100),new Point(205,115),
new Point(205,115),new Point(179,115)

});
            g.FillPolygon(myBak, new Point[] {

new Point(275,115),new Point(287,100),
new Point(287,100),new Point(301,115),
new Point(301,115),new Point(275,115)

});

            // ************* 2 - Рисуем нос ракеты ***************
            g.FillPolygon(myNos, new Point[] {

new Point(205,90),new Point(240,60),
new Point(240,60),new Point(275,90),
new Point(275,90),new Point(275,290),
new Point(275,290),new Point(205,290),
new Point(205,290),new Point(205,90)

});
            // ******** 3 - Рисуем нижнюю часть ракеты ************
            g.FillPolygon(myLine, new Point[] {

new Point(130,300),new Point(240,260),
new Point(240,260),new Point(345,300),
new Point(345,300),new Point(130,300)

});
            // ******** 4 - Рисуем часть ракеты ниже носа **********
            g.FillPolygon(myLine, new Point[] {

new Point(204,145),new Point(240,115),
new Point(240,115),new Point(276,145),
new Point(276,145),new Point(204,145)

});
            // ********** 5 - Рисуем корпус ракеты белым цветом *****
            g.FillRectangle(myShip, 204, 145, 72, 155);
            // ******* 6 - Рисуем серую полосу на корпусе ракеты *****
            g.FillRectangle(myLine, 204, 185, 72, 50);
            // *********** 7 - Рисуем пламя из сопла ракеты *********
            // Определяем графический контейнер
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Pen p = new Pen(Brushes.Red, 1);
            // Задаем координаты точек первой кривой (внутреннее пламя)
            Point[] myPointArray1 = { new Point(210, 300),
new Point(210, 330), new Point(240, 360),
new Point(270, 330), new Point(270, 300)};

            // Добавляем кривую в контейнер
            myGraphicsPath.AddCurve(myPointArray1);
            // Выводим внутренню часть пламени, закрашенную желтым цветом
            g.FillPath(myFire1, myGraphicsPath);
            // Задаем координаты точек второй кривой (внешнее пламя)
            Point[] myPointArray2 = { new Point(185, 300),
new Point(185, 360), new Point(240, 430),
new Point(295, 360), new Point(295, 300) };

            // Добавляем кривую в контейнер
            myGraphicsPath.AddCurve(myPointArray2);
            // Добавляем текст в контейнер
            myGraphicsPath.AddString("ПУСК !", new FontFamily("Times New
            Roman"), 0, 18, new Point(210, 370), new StringFormat());
            // Выводим закрашенную оранжевым цветом область
            g.FillPath(myFire2, myGraphicsPath);
            // Рисуем границы кривых
            g.DrawPath(p, myGraphicsPath);

            // Рисуем луну
            g.FillEllipse(myFire1, 10, 10, 70, 70);
            g.DrawEllipse(Pens.Yellow, 10, 10, 70, 70);
            // Рисуем звезду
            int x = 400; int y = 50;
            g.FillPolygon(myStar, new Point[] {

new Point(x,y),new Point(x+5,y+5),
new Point(x+15,y+10),new Point(x+5,y+15),
new Point(x,y+20),new Point(x-5,y+15),
new Point(x-15,y+10),new Point(x-5,y+5)

            });
        }
    }
}