namespace DemoExamPreparing
{
    partial class RegistrationForm
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
            this.WatermarkLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordRepeatLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.LoginTextobx = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.PasswordRepeatTextbox = new System.Windows.Forms.TextBox();
            this.SexSelectComboBox = new System.Windows.Forms.ComboBox();
            this.AgeTextbox = new System.Windows.Forms.TextBox();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WatermarkLabel
            // 
            this.WatermarkLabel.AutoSize = true;
            this.WatermarkLabel.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.WatermarkLabel.Location = new System.Drawing.Point(22, 9);
            this.WatermarkLabel.Name = "WatermarkLabel";
            this.WatermarkLabel.Size = new System.Drawing.Size(90, 13);
            this.WatermarkLabel.TabIndex = 0;
            this.WatermarkLabel.Text = "Developed by ωτ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(54, 22);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(47, 61);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // PasswordRepeatLabel
            // 
            this.PasswordRepeatLabel.AutoSize = true;
            this.PasswordRepeatLabel.Location = new System.Drawing.Point(31, 100);
            this.PasswordRepeatLabel.Name = "PasswordRepeatLabel";
            this.PasswordRepeatLabel.Size = new System.Drawing.Size(93, 13);
            this.PasswordRepeatLabel.TabIndex = 3;
            this.PasswordRepeatLabel.Text = "Пароль ещё раз:";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(54, 139);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(30, 13);
            this.SexLabel.TabIndex = 4;
            this.SexLabel.Text = "Пол:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(43, 179);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(52, 13);
            this.AgeLabel.TabIndex = 5;
            this.AgeLabel.Text = "Возраст:";
            // 
            // LoginTextobx
            // 
            this.LoginTextobx.Location = new System.Drawing.Point(12, 38);
            this.LoginTextobx.Name = "LoginTextobx";
            this.LoginTextobx.Size = new System.Drawing.Size(122, 20);
            this.LoginTextobx.TabIndex = 6;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(12, 77);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(122, 20);
            this.PasswordTextbox.TabIndex = 7;
            // 
            // PasswordRepeatTextbox
            // 
            this.PasswordRepeatTextbox.Location = new System.Drawing.Point(12, 116);
            this.PasswordRepeatTextbox.Name = "PasswordRepeatTextbox";
            this.PasswordRepeatTextbox.PasswordChar = '*';
            this.PasswordRepeatTextbox.Size = new System.Drawing.Size(122, 20);
            this.PasswordRepeatTextbox.TabIndex = 8;
            // 
            // SexSelectComboBox
            // 
            this.SexSelectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexSelectComboBox.FormattingEnabled = true;
            this.SexSelectComboBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.SexSelectComboBox.Location = new System.Drawing.Point(12, 155);
            this.SexSelectComboBox.Name = "SexSelectComboBox";
            this.SexSelectComboBox.Size = new System.Drawing.Size(122, 21);
            this.SexSelectComboBox.TabIndex = 9;
            // 
            // AgeTextbox
            // 
            this.AgeTextbox.Location = new System.Drawing.Point(12, 195);
            this.AgeTextbox.Name = "AgeTextbox";
            this.AgeTextbox.Size = new System.Drawing.Size(122, 20);
            this.AgeTextbox.TabIndex = 10;
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.Location = new System.Drawing.Point(12, 221);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(125, 23);
            this.RegistrationButton.TabIndex = 11;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            this.RegistrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 251);
            this.ControlBox = false;
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.AgeTextbox);
            this.Controls.Add(this.SexSelectComboBox);
            this.Controls.Add(this.PasswordRepeatTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginTextobx);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.PasswordRepeatLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.WatermarkLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WatermarkLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PasswordRepeatLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox LoginTextobx;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox PasswordRepeatTextbox;
        private System.Windows.Forms.ComboBox SexSelectComboBox;
        private System.Windows.Forms.TextBox AgeTextbox;
        private System.Windows.Forms.Button RegistrationButton;
    }
}