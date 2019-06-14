using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0614
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;

        private static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

            vx = rand.Next(-5, 6);
            vy = rand.Next(-5, 6);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Left > ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top > ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(vy);
            }

            Point p = PointToClient(MousePosition);

            if ((p.X >= label1.Left)
&& (p.X < label1.Right)
&& (p.Y >= label1.Top)
&& (p.Y < label1.Bottom)
)
            {
                label1.Location = new Point(rand.Next(0, ClientSize.Width - label1.Width), rand.Next(0, ClientSize.Height - label1.Height));
            }
            
            if  (  (p.X>=label1.Left)
                && (p.X<label1.Right)
                && (p.Y>=label1.Top)
                && (p.Y<label1.Bottom)
                )
            {
                timer1.Enabled = false;
            }

        }
    }
}
