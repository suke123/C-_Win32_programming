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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("ウィンドウを閉じますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                //「はい」をクリックしたときはウィンドウを閉じる
                e.Cancel = true;
            }
        }

        private void calculator_Click(object sender, EventArgs e)
        {
            Form calculator = new calculator();
            calculator.Show();
        }

    }
}
