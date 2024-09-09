using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szinozon_jatek
{
    public partial class Form1 : Form
    {
        Panel panel1;
        CheckBox[,] colors;
        public Form1()
        {
            InitializeComponent();
            Szinek();
            Size = new Size(1000, 900);
            BackColor = Color.IndianRed;
        }

        public void Szinek()
        {
            panel1 = new Panel();
            colors = new CheckBox[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Color myRgbColor = new Color();
                    myRgbColor = Color.FromArgb(i*80+80, i*40+j*40+80, j*80+80);

                    colors[i, j] = new CheckBox();
                    colors[i, j].Size = new Size(40, 40);
                    colors[i, j].BackColor = myRgbColor;
                    colors[i, j].Location = new Point((50 * (i % 3)), (50 * (j % 3)));
                    colors[i, j].CheckAlign = ContentAlignment.MiddleCenter;

                    colors[i, j].Parent = panel1;
                }
            }
            panel1.AutoSize = true;
            panel1.Location = new Point(50, 50);

            Controls.Add(panel1);
        }
    }
}
