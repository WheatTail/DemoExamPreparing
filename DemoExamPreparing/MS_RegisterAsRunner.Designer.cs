namespace DemoExamPreparing
{
    partial class MS_RegisterAsRunner
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
            this.GrayBackgroundLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.IveAlreadyWasHereButton = new System.Windows.Forms.Button();
            this.IamNewRunnerButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GratBackgroundFooterLabel = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GrayBackgroundLabel
            // 
            this.GrayBackgroundLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrayBackgroundLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrayBackgroundLabel.Location = new System.Drawing.Point(0, 0);
            this.GrayBackgroundLabel.Name = "GrayBackgroundLabel";
            this.GrayBackgroundLabel.Size = new System.Drawing.Size(484, 48);
            this.GrayBackgroundLabel.TabIndex = 0;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(3, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 4;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // IveAlreadyWasHereButton
            // 
            this.IveAlreadyWasHereButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IveAlreadyWasHereButton.AutoSize = true;
            this.IveAlreadyWasHereButton.Location = new System.Drawing.Point(175, 115);
            this.IveAlreadyWasHereButton.Name = "IveAlreadyWasHereButton";
            this.IveAlreadyWasHereButton.Size = new System.Drawing.Size(118, 23);
            this.IveAlreadyWasHereButton.TabIndex = 1;
            this.IveAlreadyWasHereButton.Text = "Я участвовал ранее";
            this.IveAlreadyWasHereButton.UseVisualStyleBackColor = true;
            // 
            // IamNewRunnerButton
            // 
            this.IamNewRunnerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IamNewRunnerButton.AutoSize = true;
            this.IamNewRunnerButton.Location = new System.Drawing.Point(175, 198);
            this.IamNewRunnerButton.Name = "IamNewRunnerButton";
            this.IamNewRunnerButton.Size = new System.Drawing.Size(118, 23);
            this.IamNewRunnerButton.TabIndex = 2;
            this.IamNewRunnerButton.Text = "Я новый участник";
            this.IamNewRunnerButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.Location = new System.Drawing.Point(397, 299);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeaderLabel.Location = new System.Drawing.Point(84, 17);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(170, 15);
            this.HeaderLabel.TabIndex = 5;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GratBackgroundFooterLabel
            // 
            this.GratBackgroundFooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GratBackgroundFooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GratBackgroundFooterLabel.Location = new System.Drawing.Point(0, 325);
            this.GratBackgroundFooterLabel.Name = "GratBackgroundFooterLabel";
            this.GratBackgroundFooterLabel.Size = new System.Drawing.Size(484, 36);
            this.GratBackgroundFooterLabel.TabIndex = 6;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FooterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FooterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FooterLabel.Location = new System.Drawing.Point(127, 335);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(249, 17);
            this.FooterLabel.TabIndex = 7;
            this.FooterLabel.Text = "Сколько-то дней до чего-то там";
            // 
            // MS_RegisterAsRunner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.GratBackgroundFooterLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.IamNewRunnerButton);
            this.Controls.Add(this.IveAlreadyWasHereButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_RegisterAsRunner";
            this.Text = "MS_RegisterAsRunner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GrayBackgroundLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button IveAlreadyWasHereButton;
        private System.Windows.Forms.Button IamNewRunnerButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label GratBackgroundFooterLabel;
        private System.Windows.Forms.Label FooterLabel;
    }
}