using System.Runtime.CompilerServices;

namespace GUI_Figures
{
    public partial class Form1 : Form
    {
        private Figure circle = new Circle(175, 175, 40);
       // private Figure circle = new Circle(0, 0, 40);
        private Figure square = new Square(100, 50, 50);
       // private Figure square = new Square(0, 0, 50);
        private Figure rhomb = new Rhomb(50, 100, 50, 80);
        private int step = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            switch (comboBox1.Text)
            {
                case "Circle":
                    circle.DrawBlack(g);
                    break;
                case "Square":
                    square.DrawBlack(g);
                    break;
                case "Rhomb":
                    rhomb.DrawBlack(g);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            switch (comboBox1.Text)
            {
                case "Circle":
                    circle.HideDrawingBackGround(g);
                    circle = new Circle(175, 175, 40);
                    break;
                case "Square":
                    square.HideDrawingBackGround(g);
                    square = new Square(100, 50, 50);
                    break;
                case "Rhomb":
                    rhomb.HideDrawingBackGround(g);
                    rhomb = new Rhomb(50, 100, 50, 80);
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
           // step++;
            switch (comboBox1.Text)
            {
                case "Circle":
                    circle.MoveRight(g, step);
                    break;
                case "Square":
                    square.MoveRight(g, step);
                    break;
                case "Rhomb":
                    rhomb.MoveRight(g, step);
                    break;
            }
        }
    }
}