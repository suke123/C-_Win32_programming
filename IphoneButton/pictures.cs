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
            comboBox.Items.Add("イヌ");
            comboBox.Items.Add("ネコ");
            comboBox.Items.Add("パンダ");
        }
    }
}
