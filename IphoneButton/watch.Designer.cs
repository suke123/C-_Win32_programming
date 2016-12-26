namespace IphoneButton
{
    partial class watch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.dateText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.japan = new System.Windows.Forms.RadioButton();
            this.america = new System.Windows.Forms.RadioButton();
            this.london = new System.Windows.Forms.RadioButton();
            this.china = new System.Windows.Forms.RadioButton();
            this.france = new System.Windows.Forms.RadioButton();
            this.australia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS教科書体", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "世界時計";
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.quitButton.Location = new System.Drawing.Point(92, 217);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(94, 32);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "閉じる";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.dateText.Location = new System.Drawing.Point(41, 151);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(195, 20);
            this.dateText.TabIndex = 5;
            this.dateText.Text = "0000年00月00日(〇)";
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.timeText.Location = new System.Drawing.Point(91, 184);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(97, 20);
            this.timeText.TabIndex = 6;
            this.timeText.Text = "00：00：00";
            // 
            // japan
            // 
            this.japan.AutoSize = true;
            this.japan.Checked = true;
            this.japan.Location = new System.Drawing.Point(18, 18);
            this.japan.Name = "japan";
            this.japan.Size = new System.Drawing.Size(77, 16);
            this.japan.TabIndex = 8;
            this.japan.TabStop = true;
            this.japan.Text = "日本・東京";
            this.japan.UseVisualStyleBackColor = true;
            // 
            // america
            // 
            this.america.AutoSize = true;
            this.america.Location = new System.Drawing.Point(18, 40);
            this.america.Name = "america";
            this.america.Size = new System.Drawing.Size(115, 16);
            this.america.TabIndex = 9;
            this.america.Text = "アメリカ・ニューヨーク";
            this.america.UseVisualStyleBackColor = true;
            // 
            // london
            // 
            this.london.AutoSize = true;
            this.london.Location = new System.Drawing.Point(151, 61);
            this.london.Name = "london";
            this.london.Size = new System.Drawing.Size(100, 16);
            this.london.TabIndex = 10;
            this.london.Text = "イギリス・ロンドン";
            this.london.UseVisualStyleBackColor = true;
            // 
            // china
            // 
            this.china.AutoSize = true;
            this.china.Location = new System.Drawing.Point(151, 18);
            this.china.Name = "china";
            this.china.Size = new System.Drawing.Size(77, 16);
            this.china.TabIndex = 11;
            this.china.Text = "中国・北京";
            this.china.UseVisualStyleBackColor = true;
            // 
            // france
            // 
            this.france.AutoSize = true;
            this.france.Location = new System.Drawing.Point(151, 40);
            this.france.Name = "france";
            this.france.Size = new System.Drawing.Size(80, 16);
            this.france.TabIndex = 12;
            this.france.Text = "フランス・パリ";
            this.france.UseVisualStyleBackColor = true;
            // 
            // australia
            // 
            this.australia.AutoSize = true;
            this.australia.Location = new System.Drawing.Point(18, 61);
            this.australia.Name = "australia";
            this.australia.Size = new System.Drawing.Size(127, 16);
            this.australia.TabIndex = 13;
            this.australia.Text = "オーストラリア・シドニー";
            this.australia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.france);
            this.groupBox1.Controls.Add(this.australia);
            this.groupBox1.Controls.Add(this.japan);
            this.groupBox1.Controls.Add(this.america);
            this.groupBox1.Controls.Add(this.china);
            this.groupBox1.Controls.Add(this.london);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 83);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "国・都市";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Name = "watch";
            this.Text = "watch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.RadioButton japan;
        private System.Windows.Forms.RadioButton america;
        private System.Windows.Forms.RadioButton london;
        private System.Windows.Forms.RadioButton china;
        private System.Windows.Forms.RadioButton france;
        private System.Windows.Forms.RadioButton australia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;


    }
}