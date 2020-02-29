using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        class Figure
        {
            public float x2;
            public float x1;
            public float y2;
            public float y1;
            public Pen pen;

            public Figure(Pen pen,float x1, float y1 , float x2 , float y2)
            {
                this.pen = pen;
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
            }
        }

        private Figure[] figures = new Figure[10000];
        int fg = 0;
        int md = 0;
        float r = 0;
        float t = 0;
        private PointF start;
        private PointF res;
        private float size;
        private int mode = 0;
        bool fp = true;
        bool sp = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (md == 1)
            {
                if (mode != 0)
                {
                    Pen pen = new Pen(Color.Red);
                    e.Graphics.DrawRectangle(pen, start.X, start.Y, size, size);
                }
            }
            if (md == 2)
            {
                if (mode != 0)
                {
                    Pen pen = new Pen(Color.Magenta);
                    r = (float)Math.Sqrt((res.X - start.X) * (res.X - start.X) + (res.Y - start.Y) * (res.Y - start.Y));
                    t = (float)Math.Sqrt(r*r+r*r);
                    e.Graphics.DrawEllipse(pen, start.X-r, start.Y-r, 2*r , 2*r);
                }
            }
            if (md == 3)
            {
                if (mode != 0)
                {
                    Pen pen = new Pen(Color.Magenta);
                    r = (float)Math.Sqrt((res.X - start.X) * (res.X - start.X) + (res.Y - start.Y) * (res.Y - start.Y));
                    t = (float)Math.Sqrt(r * r + r * r);
                    e.Graphics.DrawEllipse(pen, start.X - r, start.Y - r, 2 * r, 2 * r);
                    for(int i = 0 ; i <= fg-1 ; i++)
                    {
                        e.Graphics.DrawEllipse(pen,figures[i].x1, figures[i].y1, figures[i].x2, figures[i].y2);
                    }
                }
            }
            if (md == 4)
            {
                if (mode != 0)
                {
                    Pen pen = new Pen(Color.Magenta);
                    float rad = start.X - res.X;
                    if (fp)
                    {
                        figures[fg] = new Figure(pen, start.X, start.Y, rad * 2 / 3, rad * 2 / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X - rad, start.Y, rad * 2 / 3, rad * 2 / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X - rad, start.Y - rad, rad * 2 / 3, rad * 2 / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X, start.Y - rad, rad * 2 / 3, rad * 2 / 3);
                        fg++;
                        fp = false;
                    }
                    else
                    {
                        figures[fg-4] = new Figure(pen, start.X, start.Y, rad * 2 / 3, rad * 2 / 3);
                        figures[fg-3] = new Figure(pen, start.X - rad, start.Y, rad * 2 / 3, rad * 2 / 3);
                        figures[fg-2] = new Figure(pen, start.X - rad, start.Y - rad, rad * 2 / 3, rad * 2 / 3);
                        figures[fg-1] = new Figure(pen, start.X, start.Y - rad, rad * 2 / 3, rad * 2 / 3);
                    }
                    for (int i = 0; i <= fg - 1; i++)
                    {
                        e.Graphics.DrawEllipse(figures[i].pen, figures[i].x1, figures[i].y1, figures[i].x2, figures[i].y2);
                    }
                }
            }
            if (md == 5)
            {
                if (mode != 0)
                {
                    Pen pen = new Pen(Color.Magenta);
                    float rad = start.X - res.X;
                    if (fp)
                    {
                        figures[fg] = new Figure(pen, start.X, start.Y + rad, rad / 3, rad / 3 );
                        fg++;
                        figures[fg] = new Figure(pen, start.X, start.Y - rad, rad / 3, rad / 3);
                        fg++; 
                        figures[fg] = new Figure(pen, start.X + rad, start.Y, rad / 3, rad / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X - rad, start.Y, rad / 3, rad / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X + rad / (float)Math.Sqrt(2), start.Y + rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X - rad / (float)Math.Sqrt(2), start.Y - rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X + rad / (float)Math.Sqrt(2), start.Y - rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        fg++;
                        figures[fg] = new Figure(pen, start.X - rad / (float)Math.Sqrt(2), start.Y + rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        fg++;
                        fp = false;
                    }
                    else
                    {
                        figures[fg - 8] = new Figure(pen, start.X, start.Y + rad, rad / 3, rad / 3);
                        figures[fg - 7] = new Figure(pen, start.X, start.Y - rad, rad / 3, rad / 3);
                        figures[fg - 6] = new Figure(pen, start.X + rad, start.Y, rad / 3, rad / 3);
                        figures[fg - 5] = new Figure(pen, start.X - rad, start.Y, rad / 3, rad / 3);
                        figures[fg - 4] = new Figure(pen, start.X + rad / (float)Math.Sqrt(2), start.Y + rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        figures[fg - 3] = new Figure(pen, start.X - rad / (float)Math.Sqrt(2), start.Y - rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        figures[fg - 2] = new Figure(pen, start.X + rad / (float)Math.Sqrt(2), start.Y - rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                        figures[fg - 1] = new Figure(pen, start.X - rad / (float)Math.Sqrt(2), start.Y + rad / (float)Math.Sqrt(2), rad / 3, rad / 3);
                    }
                    for (int i = 0; i <= fg - 1; i++)
                    {
                        e.Graphics.DrawEllipse(figures[i].pen, figures[i].x1, figures[i].y1, figures[i].x2, figures[i].y2);
                    }
                }
            }
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new PointF(e.X, e.Y);
            fp = true;
            mode = 1;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            size = Math.Min(Math.Abs(start.X - e.X), Math.Abs(start.Y - e.Y));
            mode = 2;
            res = new PointF(e.X, e.Y);
            Refresh();
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mode == 1)
            {
                size = Math.Min(Math.Abs(start.X - e.X),
                Math.Abs(start.Y - e.Y));
                res = new PointF(e.X, e.Y);
                Refresh();
            }
        }
        private void rdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            md = 1;
        }
        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {
            md = 2;
        }
        private void четыреКругаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            md = 4;
        }
        private void четыреКругаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            md = 3;
        }
        private void восемьКруговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            md = 5;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
