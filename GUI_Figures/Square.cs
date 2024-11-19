using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Figures
{
    internal class Square:Figure
    {
        private int sideLength;
        public override void DrawBlack(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Black),xCentre,yCentre,sideLength,sideLength);
            g.FillRectangle(new SolidBrush(Color.Black), xCentre, yCentre, sideLength, sideLength);
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.DrawRectangle(new Pen(Form1.DefaultBackColor), xCentre, yCentre, sideLength, sideLength);
            g.FillRectangle(new SolidBrush(Form1.DefaultBackColor), xCentre, yCentre, sideLength, sideLength);
        }
    }
}
