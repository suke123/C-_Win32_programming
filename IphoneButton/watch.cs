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
    public partial class watch : Form
    {
        public watch()
        {
            InitializeComponent();

            dateText.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd)");
            timeText.Text = DateTime.Now.ToString("hh：mm：ss");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dateText.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd)");
            timeText.Text = DateTime.Now.ToString("hh：mm：ss");
        }

    }
}
