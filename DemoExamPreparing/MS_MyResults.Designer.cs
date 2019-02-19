namespace DemoExamPreparing
{
    partial class MS_MyResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MS_MyResults));
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GrayBackgroundLabel = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.GratBackgroundFooterLabel = new System.Windows.Forms.Label();
            this.MyResultsHeaderLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowAllResultsButton = new System.Windows.Forms.Button();
            this.MyResultsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MyResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(397, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 50;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
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
            this.HeaderLabel.TabIndex = 49;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 48;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // GrayBackgroundLabel
            // 
            this.GrayBackgroundLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GrayBackgroundLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrayBackgroundLabel.Location = new System.Drawing.Point(0, 0);
            this.GrayBackgroundLabel.Name = "GrayBackgroundLabel";
            this.GrayBackgroundLabel.Size = new System.Drawing.Size(484, 48);
            this.GrayBackgroundLabel.TabIndex = 47;
            // 
            // FooterLabel
            // 
            this.FooterLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FooterLabel.AutoSize = true;
            this.FooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FooterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FooterLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FooterLabel.Location = new System.Drawing.Point(111, 335);
            this.FooterLabel.Name = "FooterLabel";
            this.FooterLabel.Size = new System.Drawing.Size(249, 17);
            this.FooterLabel.TabIndex = 52;
            this.FooterLabel.Text = "Сколько-то дней до чего-то там";
            // 
            // GratBackgroundFooterLabel
            // 
            this.GratBackgroundFooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GratBackgroundFooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GratBackgroundFooterLabel.Location = new System.Drawing.Point(0, 325);
            this.GratBackgroundFooterLabel.Name = "GratBackgroundFooterLabel";
            this.GratBackgroundFooterLabel.Size = new System.Drawing.Size(484, 36);
            this.GratBackgroundFooterLabel.TabIndex = 51;
            // 
            // MyResultsHeaderLabel
            // 
            this.MyResultsHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyResultsHeaderLabel.Location = new System.Drawing.Point(0, 48);
            this.MyResultsHeaderLabel.Name = "MyResultsHeaderLabel";
            this.MyResultsHeaderLabel.Size = new System.Drawing.Size(484, 79);
            this.MyResultsHeaderLabel.TabIndex = 53;
            this.MyResultsHeaderLabel.Text = resources.GetString("MyResultsHeaderLabel.Text");
            this.MyResultsHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Location = new System.Drawing.Point(148, 127);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(54, 13);
            this.SexLabel.TabIndex = 54;
            this.SexLabel.Text = "Пол: ###";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Возрастная категория: ##-##";
            // 
            // ShowAllResultsButton
            // 
            this.ShowAllResultsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ShowAllResultsButton.AutoSize = true;
            this.ShowAllResultsButton.Location = new System.Drawing.Point(175, 299);
            this.ShowAllResultsButton.Name = "ShowAllResultsButton";
            this.ShowAllResultsButton.Size = new System.Drawing.Size(149, 23);
            this.ShowAllResultsButton.TabIndex = 56;
            this.ShowAllResultsButton.Text = "Показать все результаты";
            this.ShowAllResultsButton.UseVisualStyleBackColor = true;
            // 
            // MyResultsDataGridView
            // 
            this.MyResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyResultsDataGridView.Location = new System.Drawing.Point(3, 143);
            this.MyResultsDataGridView.Name = "MyResultsDataGridView";
            this.MyResultsDataGridView.Size = new System.Drawing.Size(481, 150);
            this.MyResultsDataGridView.TabIndex = 57;
            // 
            // MS_MyResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.MyResultsDataGridView);
            this.Controls.Add(this.ShowAllResultsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.MyResultsHeaderLabel);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.GratBackgroundFooterLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_MyResults";
            this.Text = "MS_MyResults";
            ((System.ComponentModel.ISupportInitialize)(this.MyResultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label GrayBackgroundLabel;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Label GratBackgroundFooterLabel;
        private System.Windows.Forms.Label MyResultsHeaderLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ShowAllResultsButton;
        private System.Windows.Forms.DataGridView MyResultsDataGridView;
    }
}