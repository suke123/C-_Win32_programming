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
    public partial class pictures : Form
    {
        public pictures()
        {
            InitializeComponent();

            comboBox.Items.Add("選択してください");
            comboBox.Items.Add("モルモット");
            comboBox.Items.Add("ゾウ");
            comboBox.Items.Add("カメ");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ani = comboBox.SelectedItem.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (ani == "モルモット")
            {
                pictureBox1.Image = imageList1.Images[0];
            }
            else if (ani == "ゾウ")
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            else if (ani == "カメ")
            {
                pictureBox1.Image = imageList1.Images[2];
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
    }
}
