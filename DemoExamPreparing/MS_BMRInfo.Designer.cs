namespace DemoExamPreparing
{
    partial class MS_BMRInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.BMRInfoHeaderLabel = new System.Windows.Forms.Label();
            this.BMRInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(414, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BMRInfoHeaderLabel
            // 
            this.BMRInfoHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BMRInfoHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMRInfoHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.BMRInfoHeaderLabel.Name = "BMRInfoHeaderLabel";
            this.BMRInfoHeaderLabel.Size = new System.Drawing.Size(450, 68);
            this.BMRInfoHeaderLabel.TabIndex = 7;
            this.BMRInfoHeaderLabel.Text = "Контакты";
            this.BMRInfoHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMRInfoLabel
            // 
            this.BMRInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BMRInfoLabel.Location = new System.Drawing.Point(0, 68);
            this.BMRInfoLabel.Name = "BMRInfoLabel";
            this.BMRInfoLabel.Size = new System.Drawing.Size(450, 282);
            this.BMRInfoLabel.TabIndex = 9;
            this.BMRInfoLabel.Text = "Здесь описание всех уровней активности\r\n\r\nСидячий:\r\n\r\nМинимальный:\r\n\r\nСредний:\r\n\r" +
    "\nВысокий:\r\n\r\nМаксимальный:";
            this.BMRInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MS_BMRInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.BMRInfoLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BMRInfoHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MS_BMRInfo";
            this.Text = "MS_BMRInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BMRInfoHeaderLabel;
        private System.Windows.Forms.Label BMRInfoLabel;
    }
}