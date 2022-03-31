using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            int height = (int)heightInput.Value;
            int width = (int)widthInput.Value;

            PathFinder pathFinder = new PathFinder(height, width, this);
            pathFinder.Show();
            this.Hide();
            pathFinder.Height = (int)heightInput.Value;
            pathFinder.Width = (int)widthInput.Value;
        }
    }
}
