using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuzikUciekajacyMaxiu
{
    public partial class Form1 : Form
    {
        readonly Random r;
        int punkty;
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            punkty = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveButton();
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkty; " + punkty.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveButton();
            punkty++;
            toolStripStatusLabel1.Text = "Punkty; " + punkty.ToString();
            timer1.Stop();
            timer1.Start();
        }
        private void MoveButton()
        {
            int maxX = this.Size.Width - button2.Size.Width - 139;
            int maxY = this.Size.Height - button2.Size.Height - 74;
            Point p = new Point();
            p.X = r.Next(139, maxX);
            p.Y = r.Next(74, maxY);
            button2.Location = p;
        }
    }
}
