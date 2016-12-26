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
            timer1.Start();          //時計を進める
        }

        //「閉じる」ボタンを押すと、フォームを閉じる
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();     //フォームを閉じる
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //日本時間
            if (japan.Checked)
            {
                dateText.Text = DateTime.Now.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = DateTime.Now.ToString("HH：mm：ss");
            }
            //ニューヨーク時間
            else if (america.Checked)
            {
                DateTime dt = DateTime.Now;
                DateTime us_dt = dt.AddHours(-14);  //時差14時間を日本時間から引く
                dateText.Text = us_dt.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = us_dt.ToString("HH：mm：ss");
            }
            //シドニー時間
            else if (australia.Checked)
            {
                DateTime dt = DateTime.Now;
                DateTime us_dt = dt.AddHours(2);    //時差2時間を日本時間に足す
                dateText.Text = us_dt.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = us_dt.ToString("HH：mm：ss");
            }
            //北京時間
            else if (china.Checked)
            {
                DateTime dt = DateTime.Now;
                DateTime us_dt = dt.AddHours(-1);   //時差1時間を日本時間から引く
                dateText.Text = us_dt.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = us_dt.ToString("HH：mm：ss");
            }
            //パリ時間
            else if (france.Checked)
            {
                DateTime dt = DateTime.Now;
                DateTime us_dt = dt.AddHours(-8);   //時差8時間を日本時間から引く
                dateText.Text = us_dt.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = us_dt.ToString("HH：mm：ss");
            }
            //ロンドン時間
            else if (london.Checked)
            {
                DateTime dt = DateTime.Now;
                DateTime us_dt = dt.AddHours(-9);   //時差9時間を日本時間から引く
                dateText.Text = us_dt.ToString("yyyy年MM月dd日(ddd)");
                timeText.Text = us_dt.ToString("HH：mm：ss");
            }
        }

    }
}
