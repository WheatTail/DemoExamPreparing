namespace DemoExamPreparing
{
    partial class MS_LoginRole
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AskTextLabel = new System.Windows.Forms.Label();
            this.RunnerLoginButton = new System.Windows.Forms.Button();
            this.ManagerLoginButton = new System.Windows.Forms.Button();
            this.AdminLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.AutoSize = true;
            this.CancelButton.ForeColor = System.Drawing.Color.DarkRed;
            this.CancelButton.Location = new System.Drawing.Point(298, 12);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(24, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "X";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AskTextLabel
            // 
            this.AskTextLabel.AutoSize = true;
            this.AskTextLabel.Location = new System.Drawing.Point(51, 53);
            this.AskTextLabel.Name = "AskTextLabel";
            this.AskTextLabel.Size = new System.Drawing.Size(289, 13);
            this.AskTextLabel.TabIndex = 1;
            this.AskTextLabel.Text = "Под каким пользователем вы хотите войти в систему?";
            // 
            // RunnerLoginButton
            // 
            this.RunnerLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RunnerLoginButton.Location = new System.Drawing.Point(168, 69);
            this.RunnerLoginButton.Name = "RunnerLoginButton";
            this.RunnerLoginButton.Size = new System.Drawing.Size(96, 23);
            this.RunnerLoginButton.TabIndex = 2;
            this.RunnerLoginButton.Text = "Бегун";
            this.RunnerLoginButton.UseVisualStyleBackColor = true;
            // 
            // ManagerLoginButton
            // 
            this.ManagerLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ManagerLoginButton.AutoSize = true;
            this.ManagerLoginButton.Location = new System.Drawing.Point(168, 118);
            this.ManagerLoginButton.Name = "ManagerLoginButton";
            this.ManagerLoginButton.Size = new System.Drawing.Size(96, 23);
            this.ManagerLoginButton.TabIndex = 3;
            this.ManagerLoginButton.Text = "Координатор";
            this.ManagerLoginButton.UseVisualStyleBackColor = true;
            // 
            // AdminLoginButton
            // 
            this.AdminLoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminLoginButton.AutoSize = true;
            this.AdminLoginButton.Location = new System.Drawing.Point(168, 169);
            this.AdminLoginButton.Name = "AdminLoginButton";
            this.AdminLoginButton.Size = new System.Drawing.Size(96, 23);
            this.AdminLoginButton.TabIndex = 4;
            this.AdminLoginButton.Text = "Администратор";
            this.AdminLoginButton.UseVisualStyleBackColor = true;
            // 
            // MS_LoginRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.ControlBox = false;
            this.Controls.Add(this.AdminLoginButton);
            this.Controls.Add(this.ManagerLoginButton);
            this.Controls.Add(this.RunnerLoginButton);
            this.Controls.Add(this.AskTextLabel);
            this.Controls.Add(this.CancelButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MS_LoginRole";
            this.Text = "MS_LoginRole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label AskTextLabel;
        private System.Windows.Forms.Button RunnerLoginButton;
        private System.Windows.Forms.Button ManagerLoginButton;
        private System.Windows.Forms.Button AdminLoginButton;
    }
}