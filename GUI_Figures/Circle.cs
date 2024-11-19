using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Figures
{
    internal class Circle:Figure
    {
        private int radius;
        public override void DrawBlack(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), xCentre, yCentre, radius, radius);
            g.FillEllipse(new SolidBrush(Color.Black), xCentre, yCentre, radius, radius);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.DrawEllipse(new Pen(Form1.DefaultBackColor), xCentre, yCentre, radius, radius);
            g.FillEllipse(new SolidBrush(Form1.DefaultBackColor), xCentre, yCentre, radius, radius);
        }
    }
}
