using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HW6._2.MainForm;

namespace HW6._2.DomainModel
{
    public class DrawModel : IDrawModel
    {
        //--------    Point     -------------//
        private bool pointStart = false;
        private List<SuperPoint> superPoints;

        //--------    Line       ------------//
        private bool lineStart = false;
        private Point onePoint;
        private Pen bluePen;
        private List<Line> lines { get; set; }

        //-----------  Circle  ---------------//
        private bool circleStart = false;
        private int heightCircle;

        private SolidBrush brush;

        //  public DiameterForm DiameterForms { get; set; }

        //  public List<Rectangle> Circles { get; set; }

        public DrawModel()
        {
            Brush = new SolidBrush(Color.Red);
            //--------   Point       ------------//
            superPoints = new List<SuperPoint>();

            // Circles = new List<Rectangle>();

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
        public bool PointStart { get => pointStart; set => pointStart = value; }
        public List<SuperPoint> SuperPoints { get => superPoints; set => superPoints = value; }
        //--------    Line       -------------//
        public bool LineStart { get => lineStart; set => lineStart = value; }
        public Point OnePoint { get => onePoint; set => onePoint = value; }
        public Pen BluePen { get => bluePen; set => bluePen = value; }
        public List<Line> Lines { get => lines; set => lines = value; }
        //-----------  Circle  ---------------//
        public bool CircleStart { get => circleStart; set => circleStart = value; }
        public int HeightCircle { get => heightCircle; set => heightCircle = value; }

        public void NewPoints(object sender, MouseEventArgs e)
        {
            SuperPoints.Add(new SuperPoint(e.Location, Brush));
        }

        public void NewLines(object sender, MouseEventArgs e)
        {
            if (OnePoint.X == 0 && OnePoint.Y == 0)
            {
                OnePoint = e.Location;
            }
            else
            {
                Lines.Add(new Line(OnePoint.X, e.X, OnePoint.Y, e.Y, BluePen));
                OnePoint = new Point();
            }
        }

        public void StopPrimitiv()
        {
            if (PointStart)
                PointStart = false;
            if (LineStart)
                LineStart = false;
            if (CircleStart)
            {
                CircleStart = false;
                //ToolDiameter.Enabled = false;
            }
        }

        public void menuColorClick()
        {
            ColorDialog myColorDialog = new ColorDialog();
            if (myColorDialog.ShowDialog() == DialogResult.OK)
            {
                Brush = new SolidBrush(myColorDialog.Color);
                BluePen = new Pen(Brush.Color, 6);
            }
        }
    }
}
