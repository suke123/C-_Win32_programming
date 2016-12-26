using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IphoneButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            Form calculator = new calculator();
            calculator.Show();
        }

        private void watch_Click(object sender, EventArgs e)
        {
            Form watch = new watch();
            watch.Show();
        }

        private void picture_Click(object sender, EventArgs e)
        {
            Form pictures = new pictures();
            pictures.Show();
        }

    }
}
