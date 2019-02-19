namespace DemoExamPreparing
{
    partial class MS_RunnerManagement
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
            this.FooterLabel = new System.Windows.Forms.Label();
            this.GratBackgroundFooterLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GrayBackgroundLabel = new System.Windows.Forms.Label();
            this.RunnerManagementHeaderLabel = new System.Windows.Forms.Label();
            this.SortAndFilterLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.SortLabel = new System.Windows.Forms.Label();
            this.ExportLabel = new System.Windows.Forms.Label();
            this.RunnersTotal = new System.Windows.Forms.Label();
            this.RunnersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.FooterLabel.TabIndex = 82;
            this.FooterLabel.Text = "Сколько-то дней до чего-то там";
            // 
            // GratBackgroundFooterLabel
            // 
            this.GratBackgroundFooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GratBackgroundFooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GratBackgroundFooterLabel.Location = new System.Drawing.Point(0, 325);
            this.GratBackgroundFooterLabel.Name = "GratBackgroundFooterLabel";
            this.GratBackgroundFooterLabel.Size = new System.Drawing.Size(484, 36);
            this.GratBackgroundFooterLabel.TabIndex = 81;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(397, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 80;
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
            this.HeaderLabel.TabIndex = 79;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 78;
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
            this.GrayBackgroundLabel.TabIndex = 77;
            // 
            // RunnerManagementHeaderLabel
            // 
            this.RunnerManagementHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RunnerManagementHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RunnerManagementHeaderLabel.Location = new System.Drawing.Point(0, 48);
            this.RunnerManagementHeaderLabel.Name = "RunnerManagementHeaderLabel";
            this.RunnerManagementHeaderLabel.Size = new System.Drawing.Size(484, 57);
            this.RunnerManagementHeaderLabel.TabIndex = 83;
            this.RunnerManagementHeaderLabel.Text = "Управление бегунами";
            this.RunnerManagementHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SortAndFilterLabel
            // 
            this.SortAndFilterLabel.AutoSize = true;
            this.SortAndFilterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortAndFilterLabel.Location = new System.Drawing.Point(9, 105);
            this.SortAndFilterLabel.Name = "SortAndFilterLabel";
            this.SortAndFilterLabel.Size = new System.Drawing.Size(183, 17);
            this.SortAndFilterLabel.TabIndex = 84;
            this.SortAndFilterLabel.Text = "Сортировка и фильтрация";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(31, 128);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(44, 13);
            this.StatusLabel.TabIndex = 85;
            this.StatusLabel.Text = "Статус:";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(9, 154);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(66, 13);
            this.DistanceLabel.TabIndex = 86;
            this.DistanceLabel.Text = "Дистанция:";
            // 
            // SortLabel
            // 
            this.SortLabel.AutoSize = true;
            this.SortLabel.Location = new System.Drawing.Point(0, 178);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(75, 13);
            this.SortLabel.TabIndex = 87;
            this.SortLabel.Text = "Сортировать:";
            // 
            // ExportLabel
            // 
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportLabel.Location = new System.Drawing.Point(367, 102);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(69, 17);
            this.ExportLabel.TabIndex = 88;
            this.ExportLabel.Text = "Выгрузка";
            // 
            // RunnersTotal
            // 
            this.RunnersTotal.AutoSize = true;
            this.RunnersTotal.Location = new System.Drawing.Point(179, 199);
            this.RunnersTotal.Name = "RunnersTotal";
            this.RunnersTotal.Size = new System.Drawing.Size(104, 13);
            this.RunnersTotal.TabIndex = 89;
            this.RunnersTotal.Text = "Всего бегунов: 000";
            // 
            // RunnersTableLayoutPanel
            // 
            this.RunnersTableLayoutPanel.ColumnCount = 2;
            this.RunnersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunnersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunnersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RunnersTableLayoutPanel.Location = new System.Drawing.Point(0, 215);
            this.RunnersTableLayoutPanel.Name = "RunnersTableLayoutPanel";
            this.RunnersTableLayoutPanel.RowCount = 2;
            this.RunnersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunnersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RunnersTableLayoutPanel.Size = new System.Drawing.Size(484, 110);
            this.RunnersTableLayoutPanel.TabIndex = 90;
            // 
            // ExportButton
            // 
            this.ExportButton.Location = new System.Drawing.Point(336, 122);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(136, 23);
            this.ExportButton.TabIndex = 91;
            this.ExportButton.Text = "Выгрузить в CSV";
            this.ExportButton.UseVisualStyleBackColor = true;
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(336, 148);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(136, 23);
            this.EmailButton.TabIndex = 92;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(208, 173);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshButton.TabIndex = 93;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 125);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 94;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(81, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 95;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(81, 151);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 96;
            // 
            // MS_RunnerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.EmailButton);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.RunnersTableLayoutPanel);
            this.Controls.Add(this.RunnersTotal);
            this.Controls.Add(this.ExportLabel);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SortAndFilterLabel);
            this.Controls.Add(this.RunnerManagementHeaderLabel);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.GratBackgroundFooterLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_RunnerManagement";
            this.Text = "MS_RunnerManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Label GratBackgroundFooterLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label GrayBackgroundLabel;
        private System.Windows.Forms.Label RunnerManagementHeaderLabel;
        private System.Windows.Forms.Label SortAndFilterLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.Label ExportLabel;
        private System.Windows.Forms.Label RunnersTotal;
        private System.Windows.Forms.TableLayoutPanel RunnersTableLayoutPanel;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}