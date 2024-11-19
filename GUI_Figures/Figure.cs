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

        abstract protected void DrawBlack();
        abstract protected void HideDrawingBackGround();

        protected void MoveRight(Graphics g,int step)
        {
            this.HideDrawingBackGround();
            xCentre += step;
            yCentre += step;
            this.DrawBlack();
        }
    }
}
