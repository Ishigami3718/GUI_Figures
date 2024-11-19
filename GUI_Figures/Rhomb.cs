using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Figures
{
    internal class Rhomb:Figure
    {
        private int horDiagLen;
        private int vertDiagLen;

        public override void DrawBlack(Graphics g)
        {
            g.DrawPolygon(new Pen(Color.Black),new Point[] {new Point(xCentre-horDiagLen/2,yCentre), 
                new Point(xCentre,yCentre-vertDiagLen/2),
                new Point(xCentre+horDiagLen/2,yCentre),
                new Point(xCentre,yCentre+vertDiagLen/2)});
            g.FillPolygon(new SolidBrush(Color.Black), new Point[] {new Point(xCentre-horDiagLen/2,yCentre),
                new Point(xCentre,yCentre-vertDiagLen/2),
                new Point(xCentre+horDiagLen/2,yCentre),
                new Point(xCentre,yCentre+vertDiagLen/2)});
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.DrawPolygon(new Pen(Form1.DefaultBackColor), new Point[] {new Point(xCentre-horDiagLen/2,yCentre),
                new Point(xCentre,yCentre-vertDiagLen/2),
                new Point(xCentre+horDiagLen/2,yCentre),
                new Point(xCentre,yCentre+vertDiagLen/2)});
            g.FillPolygon(new SolidBrush(Form1.DefaultBackColor), new Point[] {new Point(xCentre-horDiagLen/2,yCentre),
                new Point(xCentre,yCentre-vertDiagLen/2),
                new Point(xCentre+horDiagLen/2,yCentre),
                new Point(xCentre,yCentre+vertDiagLen/2)});
        }
    }
}
