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
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void result_Click(object sender, EventArgs e)
        {
            int left = Convert.ToInt32(leftText.Text);
            int right = Convert.ToInt32(rightText.Text);

            if(addButton.Checked){
                calcuText.Text = leftText.Text + "＋" + rightText.Text;
                resultText.Text = Convert.ToString(left + right);
            }
            else if (subButton.Checked)
            {
                calcuText.Text = leftText.Text + "－" + rightText.Text;
                resultText.Text = Convert.ToString(left - right);
            }
            else if (mulButton.Checked)
            {
                calcuText.Text = leftText.Text + "×" + rightText.Text;
                resultText.Text = Convert.ToString(left * right);
            }
            else if (divButton.Checked)
            {
                calcuText.Text = leftText.Text + "÷" + rightText.Text;
                resultText.Text = Convert.ToString((float)left / (float)right);
            }
            else if (perButton.Checked)
            {
                calcuText.Text = leftText.Text + "％" + rightText.Text;
                resultText.Text = Convert.ToString((float)left % (float)right);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
