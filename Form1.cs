using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class TrafficLight : Form
    {
        private Timer timerSwitch;
        public TrafficLight()
        {
            InitializeComponent();
            InitializeLights();
            InitializeTSwitch();

            RoundedEdges(); // Starts the edge rounding stuff
        }

        private void InitializeLights()
        {
            ColorRed.BackColor = Color.Gray;
            ColorYlw.BackColor = Color.Gray;
            ColorGrn.BackColor = Color.Gray;
        }

        private void InitializeTSwitch()
        {
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }

        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            if(ColorYlw.BackColor == Color.Gray)
            {
                ColorYlw.BackColor = Color.DarkOrange;
            }
            else
            {
                ColorYlw.BackColor = Color.Gray;
            }
        }

        private void RoundedEdges() // This is SO messy, might try making it clearer l8r
        {
            Rectangle r = new Rectangle(0, 0, ColorRed.Width, ColorRed.Height);
            System.Drawing.Drawing2D.GraphicsPath rp = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 150;
            rp.AddArc(r.X, r.Y, d, d, 180, 90);
            rp.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            rp.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90);
            rp.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            ColorRed.Region = new Region(rp);

            Rectangle y = new Rectangle(0, 0, ColorYlw.Width, ColorYlw.Height);
            System.Drawing.Drawing2D.GraphicsPath yp = new System.Drawing.Drawing2D.GraphicsPath();
            int f = 150;
            yp.AddArc(y.X, y.Y, f, f, 180, 90);
            yp.AddArc(y.X + y.Width - f, y.Y, f, f, 270, 90);
            yp.AddArc(y.X + y.Width - f, y.Y + y.Height - f, f, f, 0, 90);
            yp.AddArc(y.X, y.Y + y.Height - f, f, f, 90, 90);
            ColorYlw.Region = new Region(yp);

            Rectangle g = new Rectangle(0, 0, ColorGrn.Width, ColorGrn.Height);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            int e = 150;
            gp.AddArc(g.X, g.Y, e, e, 180, 90);
            gp.AddArc(g.X + g.Width - e, g.Y, e, e, 270, 90);
            gp.AddArc(g.X + g.Width - e, g.Y + g.Height - e, e, e, 0, 90);
            gp.AddArc(g.X, g.Y + g.Height - e, e, e, 90, 90);
            ColorGrn.Region = new Region(gp);
        }
    }
}
