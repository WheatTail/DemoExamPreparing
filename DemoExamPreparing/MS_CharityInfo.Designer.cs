namespace DemoExamPreparing
{
    partial class MS_CharityInfo
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
            this.SponsorNameLabel = new System.Windows.Forms.Label();
            this.SponsorDesctiption = new System.Windows.Forms.Label();
            this.CharityLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CharityLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SponsorNameLabel
            // 
            this.SponsorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SponsorNameLabel.AutoSize = true;
            this.SponsorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SponsorNameLabel.Location = new System.Drawing.Point(124, 9);
            this.SponsorNameLabel.Name = "SponsorNameLabel";
            this.SponsorNameLabel.Size = new System.Drawing.Size(172, 17);
            this.SponsorNameLabel.TabIndex = 1;
            this.SponsorNameLabel.Text = "Наименование споснора";
            // 
            // SponsorDesctiption
            // 
            this.SponsorDesctiption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SponsorDesctiption.AutoSize = true;
            this.SponsorDesctiption.Location = new System.Drawing.Point(151, 127);
            this.SponsorDesctiption.Name = "SponsorDesctiption";
            this.SponsorDesctiption.Size = new System.Drawing.Size(108, 13);
            this.SponsorDesctiption.TabIndex = 2;
            this.SponsorDesctiption.Text = "Описание спонсора";
            // 
            // CharityLogoPictureBox
            // 
            this.CharityLogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CharityLogoPictureBox.Location = new System.Drawing.Point(154, 29);
            this.CharityLogoPictureBox.Name = "CharityLogoPictureBox";
            this.CharityLogoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.CharityLogoPictureBox.TabIndex = 3;
            this.CharityLogoPictureBox.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.AutoSize = true;
            this.CancelButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelButton.Location = new System.Drawing.Point(414, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(24, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // MS_CharityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CharityLogoPictureBox);
            this.Controls.Add(this.SponsorDesctiption);
            this.Controls.Add(this.SponsorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MS_CharityInfo";
            this.Text = "CharityInfo";
            ((System.ComponentModel.ISupportInitialize)(this.CharityLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SponsorNameLabel;
        private System.Windows.Forms.Label SponsorDesctiption;
        private System.Windows.Forms.PictureBox CharityLogoPictureBox;
        private System.Windows.Forms.Button CancelButton;
    }
}