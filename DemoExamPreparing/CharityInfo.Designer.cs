namespace DemoExamPreparing
{
    partial class CharityInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SponsorNameLabel
            // 
            this.SponsorNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SponsorNameLabel.AutoSize = true;
            this.SponsorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SponsorNameLabel.Location = new System.Drawing.Point(141, 9);
            this.SponsorNameLabel.Name = "SponsorNameLabel";
            this.SponsorNameLabel.Size = new System.Drawing.Size(172, 17);
            this.SponsorNameLabel.TabIndex = 1;
            this.SponsorNameLabel.Text = "Наименование споснора";
            // 
            // SponsorDesctiption
            // 
            this.SponsorDesctiption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SponsorDesctiption.AutoSize = true;
            this.SponsorDesctiption.Location = new System.Drawing.Point(168, 132);
            this.SponsorDesctiption.Name = "SponsorDesctiption";
            this.SponsorDesctiption.Size = new System.Drawing.Size(108, 13);
            this.SponsorDesctiption.TabIndex = 2;
            this.SponsorDesctiption.Text = "Описание спонсора";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(171, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CharityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SponsorDesctiption);
            this.Controls.Add(this.SponsorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharityInfo";
            this.Text = "CharityInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SponsorNameLabel;
        private System.Windows.Forms.Label SponsorDesctiption;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}