namespace DemoExamPreparing
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegistrationButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ServerSettingTextbox = new System.Windows.Forms.TextBox();
            this.ServerSettingsLabel = new System.Windows.Forms.Label();
            this.DatabaseSettingsLabel = new System.Windows.Forms.Label();
            this.UIDSettingsLabel = new System.Windows.Forms.Label();
            this.PasswordSettingsLabel = new System.Windows.Forms.Label();
            this.DatabaseSettingsTextbox = new System.Windows.Forms.TextBox();
            this.UIDSettingsTextbox = new System.Windows.Forms.TextBox();
            this.PasswordSettingsTextbox = new System.Windows.Forms.TextBox();
            this.SaveSettingsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(72, 5);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 13);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логин:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(72, 44);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(48, 13);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль:";
            // 
            // LoginTextbox
            // 
            this.LoginTextbox.Location = new System.Drawing.Point(31, 21);
            this.LoginTextbox.Name = "LoginTextbox";
            this.LoginTextbox.Size = new System.Drawing.Size(123, 20);
            this.LoginTextbox.TabIndex = 2;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(31, 60);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(123, 20);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // SettingsCheckBox
            // 
            this.SettingsCheckBox.AutoSize = true;
            this.SettingsCheckBox.Location = new System.Drawing.Point(12, 173);
            this.SettingsCheckBox.Name = "SettingsCheckBox";
            this.SettingsCheckBox.Size = new System.Drawing.Size(170, 17);
            this.SettingsCheckBox.TabIndex = 4;
            this.SettingsCheckBox.Text = "Дополнительные настройки";
            this.SettingsCheckBox.UseVisualStyleBackColor = true;
            this.SettingsCheckBox.CheckedChanged += new System.EventHandler(this.SettingsCheckBox_CheckedChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.Location = new System.Drawing.Point(31, 86);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(123, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Авторизироваться";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegistrationButton
            // 
            this.RegistrationButton.AutoSize = true;
            this.RegistrationButton.Location = new System.Drawing.Point(31, 115);
            this.RegistrationButton.Name = "RegistrationButton";
            this.RegistrationButton.Size = new System.Drawing.Size(123, 23);
            this.RegistrationButton.TabIndex = 6;
            this.RegistrationButton.Text = "Зарегистрироваться";
            this.RegistrationButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(31, 144);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(123, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ServerSettingTextbox
            // 
            this.ServerSettingTextbox.Location = new System.Drawing.Point(60, 197);
            this.ServerSettingTextbox.Name = "ServerSettingTextbox";
            this.ServerSettingTextbox.Size = new System.Drawing.Size(122, 20);
            this.ServerSettingTextbox.TabIndex = 8;
            this.ServerSettingTextbox.Visible = false;
            // 
            // ServerSettingsLabel
            // 
            this.ServerSettingsLabel.AutoSize = true;
            this.ServerSettingsLabel.Location = new System.Drawing.Point(13, 197);
            this.ServerSettingsLabel.Name = "ServerSettingsLabel";
            this.ServerSettingsLabel.Size = new System.Drawing.Size(41, 13);
            this.ServerSettingsLabel.TabIndex = 9;
            this.ServerSettingsLabel.Text = "Server:";
            this.ServerSettingsLabel.Visible = false;
            // 
            // DatabaseSettingsLabel
            // 
            this.DatabaseSettingsLabel.AutoSize = true;
            this.DatabaseSettingsLabel.Location = new System.Drawing.Point(13, 223);
            this.DatabaseSettingsLabel.Name = "DatabaseSettingsLabel";
            this.DatabaseSettingsLabel.Size = new System.Drawing.Size(56, 13);
            this.DatabaseSettingsLabel.TabIndex = 10;
            this.DatabaseSettingsLabel.Text = "Database:";
            this.DatabaseSettingsLabel.Visible = false;
            // 
            // UIDSettingsLabel
            // 
            this.UIDSettingsLabel.AutoSize = true;
            this.UIDSettingsLabel.Location = new System.Drawing.Point(13, 249);
            this.UIDSettingsLabel.Name = "UIDSettingsLabel";
            this.UIDSettingsLabel.Size = new System.Drawing.Size(29, 13);
            this.UIDSettingsLabel.TabIndex = 11;
            this.UIDSettingsLabel.Text = "UID:";
            this.UIDSettingsLabel.Visible = false;
            // 
            // PasswordSettingsLabel
            // 
            this.PasswordSettingsLabel.AutoSize = true;
            this.PasswordSettingsLabel.Location = new System.Drawing.Point(13, 275);
            this.PasswordSettingsLabel.Name = "PasswordSettingsLabel";
            this.PasswordSettingsLabel.Size = new System.Drawing.Size(56, 13);
            this.PasswordSettingsLabel.TabIndex = 12;
            this.PasswordSettingsLabel.Text = "Password:";
            this.PasswordSettingsLabel.Visible = false;
            // 
            // DatabaseSettingsTextbox
            // 
            this.DatabaseSettingsTextbox.Location = new System.Drawing.Point(75, 220);
            this.DatabaseSettingsTextbox.Name = "DatabaseSettingsTextbox";
            this.DatabaseSettingsTextbox.Size = new System.Drawing.Size(107, 20);
            this.DatabaseSettingsTextbox.TabIndex = 13;
            this.DatabaseSettingsTextbox.Visible = false;
            // 
            // UIDSettingsTextbox
            // 
            this.UIDSettingsTextbox.Location = new System.Drawing.Point(48, 246);
            this.UIDSettingsTextbox.Name = "UIDSettingsTextbox";
            this.UIDSettingsTextbox.Size = new System.Drawing.Size(134, 20);
            this.UIDSettingsTextbox.TabIndex = 14;
            this.UIDSettingsTextbox.Visible = false;
            // 
            // PasswordSettingsTextbox
            // 
            this.PasswordSettingsTextbox.Location = new System.Drawing.Point(75, 272);
            this.PasswordSettingsTextbox.Name = "PasswordSettingsTextbox";
            this.PasswordSettingsTextbox.PasswordChar = '*';
            this.PasswordSettingsTextbox.Size = new System.Drawing.Size(107, 20);
            this.PasswordSettingsTextbox.TabIndex = 15;
            this.PasswordSettingsTextbox.Visible = false;
            // 
            // SaveSettingsCheckBox
            // 
            this.SaveSettingsCheckBox.AutoSize = true;
            this.SaveSettingsCheckBox.Location = new System.Drawing.Point(12, 298);
            this.SaveSettingsCheckBox.Name = "SaveSettingsCheckBox";
            this.SaveSettingsCheckBox.Size = new System.Drawing.Size(155, 17);
            this.SaveSettingsCheckBox.TabIndex = 16;
            this.SaveSettingsCheckBox.Text = "Сохранить эти настройки";
            this.SaveSettingsCheckBox.UseVisualStyleBackColor = true;
            this.SaveSettingsCheckBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 191);
            this.ControlBox = false;
            this.Controls.Add(this.SaveSettingsCheckBox);
            this.Controls.Add(this.PasswordSettingsTextbox);
            this.Controls.Add(this.UIDSettingsTextbox);
            this.Controls.Add(this.DatabaseSettingsTextbox);
            this.Controls.Add(this.PasswordSettingsLabel);
            this.Controls.Add(this.UIDSettingsLabel);
            this.Controls.Add(this.DatabaseSettingsLabel);
            this.Controls.Add(this.ServerSettingsLabel);
            this.Controls.Add(this.ServerSettingTextbox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SettingsCheckBox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.CheckBox SettingsCheckBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegistrationButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ServerSettingTextbox;
        private System.Windows.Forms.Label ServerSettingsLabel;
        private System.Windows.Forms.Label DatabaseSettingsLabel;
        private System.Windows.Forms.Label UIDSettingsLabel;
        private System.Windows.Forms.Label PasswordSettingsLabel;
        private System.Windows.Forms.TextBox DatabaseSettingsTextbox;
        private System.Windows.Forms.TextBox UIDSettingsTextbox;
        private System.Windows.Forms.TextBox PasswordSettingsTextbox;
        private System.Windows.Forms.CheckBox SaveSettingsCheckBox;
    }
}

