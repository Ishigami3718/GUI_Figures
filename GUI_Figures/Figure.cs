using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace GUI_Figures
{
    internal abstract class Figure
    {
        protected int xCentre;
        protected int yCentre;

        public Figure(int x,int y)
        {
            xCentre = x;
            yCentre = y;
        }

        abstract public void DrawBlack(Graphics g);
        abstract public void HideDrawingBackGround(Graphics g);

        public void MoveRight(Graphics g,int step)
        {
            this.HideDrawingBackGround(g);
            xCentre += step;
            this.DrawBlack(g);
        }
    }
}
