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
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.dateText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HGS教科書体", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(222, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "世界の時間";
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.quitButton.Location = new System.Drawing.Point(157, 217);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(94, 32);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "閉じる";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.refreshButton.Location = new System.Drawing.Point(30, 217);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(94, 31);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "更新";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.dateText.Location = new System.Drawing.Point(50, 149);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(0, 20);
            this.dateText.TabIndex = 5;
            // 
            // timeText
            // 
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.timeText.Location = new System.Drawing.Point(50, 181);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(0, 20);
            this.timeText.TabIndex = 6;
            // 
            // watch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.dateText);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Name = "watch";
            this.Text = "watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label timeText;


    }
}