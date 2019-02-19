namespace DemoExamPreparing
{
    partial class MS_Contacts
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
            this.ContactsHeaderLabel = new System.Windows.Forms.Label();
            this.Contacnstlabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContactsHeaderLabel
            // 
            this.ContactsHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.ContactsHeaderLabel.Name = "ContactsHeaderLabel";
            this.ContactsHeaderLabel.Size = new System.Drawing.Size(450, 68);
            this.ContactsHeaderLabel.TabIndex = 0;
            this.ContactsHeaderLabel.Text = "Контакты";
            this.ContactsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Contacnstlabel
            // 
            this.Contacnstlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contacnstlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contacnstlabel.Location = new System.Drawing.Point(0, 68);
            this.Contacnstlabel.Name = "Contacnstlabel";
            this.Contacnstlabel.Size = new System.Drawing.Size(450, 282);
            this.Contacnstlabel.TabIndex = 1;
            this.Contacnstlabel.Text = "Для получения дополнительной информации пожалуйста свяжитесь с координаторами\r\n\r\n" +
    "Телефон: +55 11 9988 7766\r\n\r\nEmail:  coordinators@marathonskills.org\r\n";
            this.Contacnstlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // MS_Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Contacnstlabel);
            this.Controls.Add(this.ContactsHeaderLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(450, 350);
            this.Name = "MS_Contacts";
            this.Text = "MS_Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsHeaderLabel;
        private System.Windows.Forms.Label Contacnstlabel;
        private System.Windows.Forms.Button CancelButton;
    }
}