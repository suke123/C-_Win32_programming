namespace IphoneButton
{
    partial class calculator
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
            this.leftText = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subButton = new System.Windows.Forms.RadioButton();
            this.mulButton = new System.Windows.Forms.RadioButton();
            this.divButton = new System.Windows.Forms.RadioButton();
            this.perButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calcuText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // leftText
            // 
            this.leftText.Location = new System.Drawing.Point(12, 49);
            this.leftText.Multiline = true;
            this.leftText.Name = "leftText";
            this.leftText.Size = new System.Drawing.Size(104, 33);
            this.leftText.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.addButton.Location = new System.Drawing.Point(140, 51);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 20);
            this.addButton.TabIndex = 2;
            this.addButton.TabStop = true;
            this.addButton.Text = "＋　加算";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.subButton.Location = new System.Drawing.Point(140, 77);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(85, 20);
            this.subButton.TabIndex = 3;
            this.subButton.TabStop = true;
            this.subButton.Text = "－　減算";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // mulButton
            // 
            this.mulButton.AutoSize = true;
            this.mulButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.mulButton.Location = new System.Drawing.Point(140, 103);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(85, 20);
            this.mulButton.TabIndex = 4;
            this.mulButton.TabStop = true;
            this.mulButton.Text = "×　乗算";
            this.mulButton.UseVisualStyleBackColor = true;
            // 
            // divButton
            // 
            this.divButton.AutoSize = true;
            this.divButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.divButton.Location = new System.Drawing.Point(140, 129);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(85, 20);
            this.divButton.TabIndex = 5;
            this.divButton.TabStop = true;
            this.divButton.Text = "÷　除算";
            this.divButton.UseVisualStyleBackColor = true;
            // 
            // perButton
            // 
            this.perButton.AutoSize = true;
            this.perButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.perButton.Location = new System.Drawing.Point(140, 155);
            this.perButton.Name = "perButton";
            this.perButton.Size = new System.Drawing.Size(85, 20);
            this.perButton.TabIndex = 6;
            this.perButton.TabStop = true;
            this.perButton.Text = "％　余剰";
            this.perButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "左辺";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(273, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "右辺";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.DarkOrange;
            this.result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.result.Location = new System.Drawing.Point(12, 188);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(90, 28);
            this.result.TabIndex = 10;
            this.result.Text = "計算";
            this.result.UseVisualStyleBackColor = false;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(23, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "計算式：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(43, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "結果：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(12, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Quit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 33);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calcuText
            // 
            this.calcuText.BackColor = System.Drawing.SystemColors.Menu;
            this.calcuText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calcuText.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.calcuText.ForeColor = System.Drawing.SystemColors.Control;
            this.calcuText.Location = new System.Drawing.Point(108, 229);
            this.calcuText.Multiline = true;
            this.calcuText.Name = "calcuText";
            this.calcuText.Size = new System.Drawing.Size(224, 20);
            this.calcuText.TabIndex = 15;
            // 
            // resultText
            // 
            this.resultText.BackColor = System.Drawing.SystemColors.Menu;
            this.resultText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultText.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.resultText.Location = new System.Drawing.Point(108, 259);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(224, 20);
            this.resultText.TabIndex = 16;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.calcuText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.leftText);
            this.Name = "calculator";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox leftText;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subButton;
        private System.Windows.Forms.RadioButton mulButton;
        private System.Windows.Forms.RadioButton divButton;
        private System.Windows.Forms.RadioButton perButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox calcuText;
        private System.Windows.Forms.TextBox resultText;
    }
}