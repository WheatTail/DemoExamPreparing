namespace DemoExamPreparing
{
    partial class MS_Inventory
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
            this.InventoryHeaderLabel = new System.Windows.Forms.Label();
            this.InventoryRunnersTotallabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.InventoryReportButton = new System.Windows.Forms.Button();
            this.InventoryIncomingButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.FooterLabel.TabIndex = 50;
            this.FooterLabel.Text = "Сколько-то дней до чего-то там";
            // 
            // GratBackgroundFooterLabel
            // 
            this.GratBackgroundFooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GratBackgroundFooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GratBackgroundFooterLabel.Location = new System.Drawing.Point(0, 325);
            this.GratBackgroundFooterLabel.Name = "GratBackgroundFooterLabel";
            this.GratBackgroundFooterLabel.Size = new System.Drawing.Size(484, 36);
            this.GratBackgroundFooterLabel.TabIndex = 49;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoutButton.Location = new System.Drawing.Point(397, 12);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 48;
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
            this.HeaderLabel.TabIndex = 47;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 46;
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
            this.GrayBackgroundLabel.TabIndex = 45;
            // 
            // InventoryHeaderLabel
            // 
            this.InventoryHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.InventoryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InventoryHeaderLabel.Location = new System.Drawing.Point(0, 48);
            this.InventoryHeaderLabel.Name = "InventoryHeaderLabel";
            this.InventoryHeaderLabel.Size = new System.Drawing.Size(484, 55);
            this.InventoryHeaderLabel.TabIndex = 51;
            this.InventoryHeaderLabel.Text = "Инвентарь";
            this.InventoryHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryRunnersTotallabel
            // 
            this.InventoryRunnersTotallabel.AutoSize = true;
            this.InventoryRunnersTotallabel.Location = new System.Drawing.Point(-2, 90);
            this.InventoryRunnersTotallabel.Name = "InventoryRunnersTotallabel";
            this.InventoryRunnersTotallabel.Size = new System.Drawing.Size(265, 13);
            this.InventoryRunnersTotallabel.TabIndex = 52;
            this.InventoryRunnersTotallabel.Text = "Всего зарегистрировано бегунов на марафон: 000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 190);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Состав комплекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryReportButton
            // 
            this.InventoryReportButton.Location = new System.Drawing.Point(12, 299);
            this.InventoryReportButton.Name = "InventoryReportButton";
            this.InventoryReportButton.Size = new System.Drawing.Size(75, 23);
            this.InventoryReportButton.TabIndex = 54;
            this.InventoryReportButton.Text = "Отчёт";
            this.InventoryReportButton.UseVisualStyleBackColor = true;
            // 
            // InventoryIncomingButton
            // 
            this.InventoryIncomingButton.AutoSize = true;
            this.InventoryIncomingButton.Location = new System.Drawing.Point(389, 299);
            this.InventoryIncomingButton.Name = "InventoryIncomingButton";
            this.InventoryIncomingButton.Size = new System.Drawing.Size(83, 23);
            this.InventoryIncomingButton.TabIndex = 55;
            this.InventoryIncomingButton.Text = "Поступление";
            this.InventoryIncomingButton.UseVisualStyleBackColor = true;
            // 
            // MS_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.InventoryIncomingButton);
            this.Controls.Add(this.InventoryReportButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.InventoryRunnersTotallabel);
            this.Controls.Add(this.InventoryHeaderLabel);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.GratBackgroundFooterLabel);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_Inventory";
            this.Text = "MS_Inventory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label InventoryHeaderLabel;
        private System.Windows.Forms.Label InventoryRunnersTotallabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button InventoryReportButton;
        private System.Windows.Forms.Button InventoryIncomingButton;
        private System.Windows.Forms.Label label1;
    }
}