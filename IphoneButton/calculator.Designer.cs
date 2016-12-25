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
            this.rightText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftText
            // 
            this.leftText.Location = new System.Drawing.Point(25, 49);
            this.leftText.Multiline = true;
            this.leftText.Name = "leftText";
            this.leftText.Size = new System.Drawing.Size(149, 33);
            this.leftText.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(192, 75);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(67, 16);
            this.addButton.TabIndex = 2;
            this.addButton.TabStop = true;
            this.addButton.Text = "＋　加算";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // subButton
            // 
            this.subButton.AutoSize = true;
            this.subButton.Location = new System.Drawing.Point(192, 97);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(67, 16);
            this.subButton.TabIndex = 3;
            this.subButton.TabStop = true;
            this.subButton.Text = "－　減算";
            this.subButton.UseVisualStyleBackColor = true;
            // 
            // mulButton
            // 
            this.mulButton.AutoSize = true;
            this.mulButton.Location = new System.Drawing.Point(192, 119);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(67, 16);
            this.mulButton.TabIndex = 4;
            this.mulButton.TabStop = true;
            this.mulButton.Text = "×　乗算";
            this.mulButton.UseVisualStyleBackColor = true;
            // 
            // divButton
            // 
            this.divButton.AutoSize = true;
            this.divButton.Location = new System.Drawing.Point(192, 141);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(67, 16);
            this.divButton.TabIndex = 5;
            this.divButton.TabStop = true;
            this.divButton.Text = "÷　除算";
            this.divButton.UseVisualStyleBackColor = true;
            // 
            // perButton
            // 
            this.perButton.AutoSize = true;
            this.perButton.Location = new System.Drawing.Point(192, 163);
            this.perButton.Name = "perButton";
            this.perButton.Size = new System.Drawing.Size(67, 16);
            this.perButton.TabIndex = 6;
            this.perButton.TabStop = true;
            this.perButton.Text = "％　余剰";
            this.perButton.UseVisualStyleBackColor = true;
            // 
            // rightText
            // 
            this.rightText.Location = new System.Drawing.Point(305, 49);
            this.rightText.Multiline = true;
            this.rightText.Name = "rightText";
            this.rightText.Size = new System.Drawing.Size(149, 33);
            this.rightText.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "左辺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(356, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "右辺";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 402);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightText);
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
        private System.Windows.Forms.TextBox rightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}