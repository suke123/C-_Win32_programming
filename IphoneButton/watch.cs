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

            dateText.Text = DateTime.Now.ToString("yyyy年MM月dd日");
            timeText.Text = DateTime.Now.ToString("hh時mm分ss秒");
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
