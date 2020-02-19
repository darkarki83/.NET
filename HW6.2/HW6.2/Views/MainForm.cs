using HW6._2.DomainModel;
using HW6._2.Views;
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

namespace HW6._2
{
    public partial class MainForm : Form, IDrawViews
    {
        private SolidBrush brush;
        //--------    Point     -------------//
        private bool pointStart = false;
        private List<SuperPoint> superPoints;

        //--------    Line       ------------//
        private bool lineStart = false;
        private Point onePoint;
        private Pen bluePen;
        private List<Line> lines;

        //-----------  Circle  ---------------//
        private bool circleStart = false;
        private int heightCircle;

        //------------
        public DiameterForm DiameterForms { get; set; }

        public List<Rectangle> Circles { get; set; }

        //------------
        public event EventHandler<MouseEventArgs> MouseClickForm;
        public event EventHandler ToolPointClick;
        public event EventHandler ToolLineClick;
        public event EventHandler MenuItemColor;

        public MainForm()
        {
            InitializeComponent();

            Brush = new SolidBrush(Color.Red);

            //--------    Point     -------------//
            SuperPoints = new List<SuperPoint>();

            Circles = new List<Rectangle>();

            //--------    Line       ------------//
            onePoint = new Point();
            BluePen = new Pen(Brush.Color, 6);
            BluePen.StartCap = LineCap.Round;
            BluePen.EndCap = LineCap.Round;
            BluePen.DashStyle = DashStyle.Solid;
            BluePen.DashCap = DashCap.Round;
            lines = new List<Line>();

            //-----------  Circle  ---------------//
            HeightCircle = 100;

            
        }

        public SolidBrush Brush { get => brush; set => brush = value; }
        //--------    Point     -------------//
        public bool PointStart { get => pointStart ; set => pointStart = value; }

        public List<SuperPoint> SuperPoints { get => superPoints; set => superPoints = value; }
        
        //--------    Line       -------------//
        
        public bool LineStart { get => lineStart; set => lineStart = value; }
       
        public Point OnePoint { get => onePoint; set => onePoint = value; }
        
        public Pen BluePen { get => bluePen; set => bluePen = value; }

        public List<Line> Lines { get => lines; set => lines = value; }
        
        //-----------  Circle  ---------------//
        public bool CircleStart { get => circleStart; set => circleStart = value; }
        public int HeightCircle { get => heightCircle; set => heightCircle = value; }


        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics gp = e.Graphics;

            gp.FillEllipse(Brush, OnePoint.X, OnePoint.Y, 6f, 6f);

            foreach (var item in SuperPoints)
            {
                gp.FillEllipse(item.OneBrush, item.OnePoint.X, item.OnePoint.Y, 10f, 10f);
            }

            foreach (var item in Lines)
            {
                gp.DrawLine(item.BluePen, item.X1, item.Y1, item.X2, item.Y2);
            }

            foreach (var item in Circles)
            {
                gp.FillEllipse(Brush, item);
            }
        }

        private void MainForm_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            MouseClickForm(sender, e);
            if (circleStart)
            {
                Circles.Add(new Rectangle(e.X - 10, e.Y - 10, HeightCircle, HeightCircle));
            }

            Invalidate();
        }

        private void toolPoint_Click(object sender, EventArgs e)
        {
            ToolPointClick(sender, e);
        }

        private void toolLine_Click(object sender, EventArgs e)
        {
            ToolLineClick(sender, e);
        }

        private void toolCircle_Click(object sender, EventArgs e)
        {
            circleStart = true;
            toolDiameter.Enabled = true;
        }

        private void menuItemColor_Click(object sender, EventArgs e)
        {
            MenuItemColor(sender, e);
            Invalidate();
        }

        public class Circle
        {
            public int X1;
            public int X2;
            public int Height;

            public Circle(int x1, int x2, int height)
            {
                X1 = x1;
                X2 = x2;
                Height = height;
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            //StartPrimitiv();
            SuperPoints = new List<SuperPoint>();
            Lines = new List<Line>();
            Circles = new List<Rectangle>();
            HeightCircle = 100;
            OnePoint = new Point();
            Invalidate();
        }

        private void toolDiameter_Click(object sender, EventArgs e)
        {
            DiameterForms = new DiameterForm();
            DiameterForms.Owner = this;
            DiameterForms.ShowDialog();
            
            DiameterForms.BringToFront();
        }
    }
}
