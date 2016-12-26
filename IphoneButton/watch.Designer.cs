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
            this.dateText = new System.Windows.Forms.TextBox();
            this.timeText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateText
            // 
            this.dateText.BackColor = System.Drawing.SystemColors.Menu;
            this.dateText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateText.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.dateText.Location = new System.Drawing.Point(0, 130);
            this.dateText.Multiline = true;
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(284, 32);
            this.dateText.TabIndex = 0;
            this.dateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeText
            // 
            this.timeText.BackColor = System.Drawing.SystemColors.Menu;
            this.timeText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeText.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.timeText.Location = new System.Drawing.Point(0, 168);
            this.timeText.Multiline = true;
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(284, 33);
            this.timeText.TabIndex = 1;
            this.timeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeText.TextChanged += new System.EventHandler(this.timeText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "現在の日時";
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.quitButton.Location = new System.Drawing.Point(97, 217);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(94, 32);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "閉じる";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.dateText);
            this.Name = "watch";
            this.Text = "watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.TextBox timeText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitButton;


    }
}