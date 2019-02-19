namespace DemoExamPreparing
{
    partial class MS_Certificate
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
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GrayBackgroundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventLabel = new System.Windows.Forms.Label();
            this.RunnerDataLabel = new System.Windows.Forms.Label();
            this.SertificateDescriptionLabel = new System.Windows.Forms.Label();
            this.CharityLabel = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CertificatePictureBox = new System.Windows.Forms.PictureBox();
            this.MarathonTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(397, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 127;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeaderLabel.Location = new System.Drawing.Point(93, 17);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(170, 15);
            this.HeaderLabel.TabIndex = 126;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 125;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // GrayBackgroundLabel
            // 
            this.GrayBackgroundLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrayBackgroundLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrayBackgroundLabel.Location = new System.Drawing.Point(0, 0);
            this.GrayBackgroundLabel.Name = "GrayBackgroundLabel";
            this.GrayBackgroundLabel.Size = new System.Drawing.Size(484, 48);
            this.GrayBackgroundLabel.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 40);
            this.label1.TabIndex = 130;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EventLabel.Location = new System.Drawing.Point(123, 64);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(57, 13);
            this.EventLabel.TabIndex = 131;
            this.EventLabel.Text = "Марафон:";
            // 
            // RunnerDataLabel
            // 
            this.RunnerDataLabel.AutoSize = true;
            this.RunnerDataLabel.Location = new System.Drawing.Point(43, 144);
            this.RunnerDataLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.RunnerDataLabel.Name = "RunnerDataLabel";
            this.RunnerDataLabel.Size = new System.Drawing.Size(380, 26);
            this.RunnerDataLabel.TabIndex = 132;
            this.RunnerDataLabel.Text = "Поздравляем Имя Фамилия с участием в 42km полном марафоне. Ваши результаты время " +
    "4:13:45 и занятое место 183rd!";
            this.RunnerDataLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SertificateDescriptionLabel
            // 
            this.SertificateDescriptionLabel.AutoSize = true;
            this.SertificateDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SertificateDescriptionLabel.Location = new System.Drawing.Point(156, 170);
            this.SertificateDescriptionLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.SertificateDescriptionLabel.Name = "SertificateDescriptionLabel";
            this.SertificateDescriptionLabel.Size = new System.Drawing.Size(161, 119);
            this.SertificateDescriptionLabel.TabIndex = 133;
            this.SertificateDescriptionLabel.Text = "Сертификат участника\r\n\r\nВ\r\n\r\nMarathon Skills 2014\r\n\r\nOsaka, Japan\r\n";
            this.SertificateDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharityLabel
            // 
            this.CharityLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CharityLabel.Location = new System.Drawing.Point(0, 305);
            this.CharityLabel.Name = "CharityLabel";
            this.CharityLabel.Size = new System.Drawing.Size(484, 56);
            this.CharityLabel.TabIndex = 134;
            this.CharityLabel.Text = "Вы также заработали$1,300\r\n для вашей благотворительной организации!\r\n";
            this.CharityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Location = new System.Drawing.Point(142, 91);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(200, 50);
            this.LogoPictureBox.TabIndex = 135;
            this.LogoPictureBox.TabStop = false;
            // 
            // CertificatePictureBox
            // 
            this.CertificatePictureBox.Location = new System.Drawing.Point(372, 249);
            this.CertificatePictureBox.Name = "CertificatePictureBox";
            this.CertificatePictureBox.Size = new System.Drawing.Size(100, 100);
            this.CertificatePictureBox.TabIndex = 136;
            this.CertificatePictureBox.TabStop = false;
            // 
            // MarathonTypeComboBox
            // 
            this.MarathonTypeComboBox.FormattingEnabled = true;
            this.MarathonTypeComboBox.Location = new System.Drawing.Point(186, 61);
            this.MarathonTypeComboBox.Name = "MarathonTypeComboBox";
            this.MarathonTypeComboBox.Size = new System.Drawing.Size(156, 21);
            this.MarathonTypeComboBox.TabIndex = 137;
            // 
            // MS_Certificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.MarathonTypeComboBox);
            this.Controls.Add(this.CertificatePictureBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.CharityLabel);
            this.Controls.Add(this.SertificateDescriptionLabel);
            this.Controls.Add(this.RunnerDataLabel);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_Certificate";
            this.Text = "MS_Certificate";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CertificatePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label GrayBackgroundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EventLabel;
        private System.Windows.Forms.Label RunnerDataLabel;
        private System.Windows.Forms.Label SertificateDescriptionLabel;
        private System.Windows.Forms.Label CharityLabel;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.PictureBox CertificatePictureBox;
        private System.Windows.Forms.ComboBox MarathonTypeComboBox;
    }
}