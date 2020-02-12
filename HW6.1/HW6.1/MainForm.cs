using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6._1
{
    public partial class MainForm : Form
    {
        List<figure> Figur { get; set; }
        public MainForm()
        {
            InitializeComponent();
            List<figure> Figur = new List<figure>();
            Figur.Add(new PawnWhite());
            Figur.Add(new СastleWhite());
            Figur.Add(new KnightWhite());
            Figur.Add(new BishopWhite());
            Figur.Add(new KingWhite());
            Figur.Add(new QueenWhite());
            Figur.Add(new PawnBlack());
            Figur.Add(new СastleBlack());
            Figur.Add(new KnightBlack());
            Figur.Add(new BishopBlack());
            Figur.Add(new KingBlack());
            Figur.Add(new QueenBlack());
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            /*
            Graphics grafic = e.Graphics;
            Pen pn = new Pen(Brushes.Red, 10);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            grafic.DrawEllipse(pn, 50, 100, 270, 200);
            grafic.DrawLine(pn, 50, 20, 500, 200);
            grafic.Dispose();*/   // рисование ручкой pen.

            /*Graphics graphics = e.Graphics;
            Rectangle rect = new Rectangle(20, 20, 200, 50);// создания ректангела
            LinearGradientBrush linear = new LinearGradientBrush(rect, Color.Red, Color.Blue, 0.1f, true); // с двумя цветами
            graphics.FillRectangle(linear, rect);

            Rectangle rect2 = new Rectangle(20, 100, 200, 50);// создания ректангела
            HatchBrush hatch = new HatchBrush(HatchStyle.Cross, Color.Blue); //  в сеточку
            graphics.FillRectangle(hatch, rect2);

            TextureBrush texture = new TextureBrush(new Bitmap("ar.jpg"));  //  в кортинку
            Rectangle rect3 = new Rectangle(20, 180, 200, 50);

            graphics.FillRectangle(texture, rect3);

            graphics.Dispose();*/

            /*Font f = new Font("Verdana", 35, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);  // шрифт, размер, и стили
            Graphics graphics = e.Graphics;
            graphics.DrawString("Vsem Priveeeet", f, Brushes.Red, 50, 50);
            graphics.Dispose();*/

            /* Graphics g = e.Graphics;
             g.PageUnit = GraphicsUnit.Pixel;
             Rectangle rect = this.ClientRectangle;
             Image im = new Bitmap("ar.jpg");
             g.DrawImage(im, 0, 0, 600, 600);
             g.Dispose();*/

            /* Graphics g = e.Graphics;

             Point[] point =
             {
                new Point(5,10),
                new Point(23, 130),
                new Point(130, 57),
                new Point(200, 167),
                new Point(300, 250),
                new Point(350, 57),

             };

             GraphicsPath path = new GraphicsPath(); // 
             /*path.StartFigure();                    // нужын если больше одного обьекта
             path.AddEllipse(400, 100, 30, 20);   // создание элипсы
             path.AddEllipse(000, 100, 30, 20);   // создание элипсы

             g.FillPath(Brushes.Red, path);         // заполнить что получилось



             //Pen pen = new Pen(Color.Green);

             //path.AddString("ssddsddds  nsndj", FontFamily.GenericSerif, 30, 100, new PointF(0, 0), StringFormat.GenericDefault);
             //g.DrawPath(pen, path);
             path.StartFigure();
             path.AddCurve(point, 0.5F);
             path.AddArc(200, 150, 300, 300, 100, 120);
             path.AddLine(50, 150, 50, 220);

             g.DrawPath(new Pen(Color.Red), path);

             g.Dispose();*/

            Color cust1 = Color.FromArgb(255, 204, 153);
            Color cust2 = Color.FromArgb(182, 103, 200);
            SolidBrush WhiteBrush = new SolidBrush(cust1);
            SolidBrush BlackBrush = new SolidBrush(cust2);
            Graphics gs = this.CreateGraphics();
            Rectangle[,] rect = new Rectangle[8, 8];
            Pen BlackPen = new Pen(cust2);
            Rectangle border = new Rectangle(99, 99, 341, 341);
            gs.DrawRectangle(BlackPen, border);
            gs.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            gs.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            gs.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            
            for (int i = 0; i < 8; i++)                 //заполняем массив
                for (int j = 0; j < 8; j++)
                    rect[i, j] = new Rectangle(50 + ((i + 1) * 50), 50 + ((j + 1) * 50), 50, 50);
                 
            for (int i = 0; i < 8; i++)                 //красим клетки в нужный цвет
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                        gs.FillRectangle(WhiteBrush, rect[i, j]);
                    else
                        gs.FillRectangle(BlackBrush, rect[i, j]);
                }
            }

            for (int i = 0; i < 400; i += 50)
                gs.DrawImage(Figur[0].Image, new Rectangle(102 + i, 102 + (50 * 6), 45, 45));
            gs.DrawImage(Figur[1].Image, new Rectangle(102, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[1].Image, new Rectangle(102 + 350, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[2].Image, new Rectangle(102 + 50, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[2].Image, new Rectangle(102 + 300, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[3].Image, new Rectangle(102 + 100, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[3].Image, new Rectangle(102 + 250, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[4].Image, new Rectangle(102 + 150, 102 + (50 * 7), 45, 45));
            gs.DrawImage(Figur[5].Image, new Rectangle(102 + 200, 102 + (50 * 7), 45, 45));


            for (int i = 0; i < 400; i += 50)
                gs.DrawImage(Figur[6].Image, new Rectangle(102 + i, 102 + 50, 45, 45));

            gs.DrawImage(Figur[7].Image, new Rectangle(102, 102 , 45, 45));
            gs.DrawImage(Figur[7].Image, new Rectangle(102 + 350, 102, 45, 45));
            gs.DrawImage(Figur[8].Image, new Rectangle(102 + 50, 102, 45, 45));
            gs.DrawImage(Figur[8].Image, new Rectangle(102 + 300, 102, 45, 45));
            gs.DrawImage(Figur[9].Image, new Rectangle(102 + 100, 102, 45, 45));
            gs.DrawImage(Figur[9].Image, new Rectangle(102 + 250, 102, 45, 45));
            gs.DrawImage(Figur[10].Image, new Rectangle(102 + 150, 102, 45, 45));
            gs.DrawImage(Figur[11].Image, new Rectangle(102 + 200, 102, 45, 45));

        }
        public class figure
        {
            string name;
            int x;
            int y;
            public figure()
            {
                this.name = null;
            }
            public figure(string n)
            {
                this.name = n;
            }

            public virtual Image Image { get;}

        }

        public class PawnWhite : figure
        {
            public Image imege = Image.FromFile(@"белаяП.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class СastleWhite : figure
        {
            public Image imege = Image.FromFile(@"белаяЛ.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class KnightWhite : figure
        {
            public Image imege = Image.FromFile(@"белыйКонь.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class BishopWhite : figure
        {
            public Image imege = Image.FromFile(@"белыйС.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class KingWhite : figure
        {
            public Image imege = Image.FromFile(@"белыйК.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class QueenWhite : figure
        {
            public Image imege = Image.FromFile(@"WhiteQ.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class PawnBlack : figure
        {
            public Image imege = Image.FromFile(@"чернаП.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class СastleBlack : figure
        {
            public Image imege = Image.FromFile(@"чернаяЛ.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class KnightBlack : figure
        {
            public Image imege = Image.FromFile(@"черныйК.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class BishopBlack : figure
        {
            public Image imege = Image.FromFile(@"черныйС.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class KingBlack : figure
        {
            public Image imege = Image.FromFile(@"Blackking.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        public class QueenBlack : figure
        {
            public Image imege = Image.FromFile(@"черныйФ.jpg");

            public override Image Image
            {
                get => imege;
            }
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
