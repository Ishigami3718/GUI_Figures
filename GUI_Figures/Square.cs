﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_Figures
{
    internal class Square:Figure
    {
        private int sideLength;

        public Square(int x, int y,int sL) : base(x-sL/2,y-sL/2)
        {
            sideLength = sL;
        }
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
