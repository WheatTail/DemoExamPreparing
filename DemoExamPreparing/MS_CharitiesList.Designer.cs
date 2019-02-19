namespace DemoExamPreparing
{
    partial class MS_CharitiesList
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.GrayBackgroundLabel = new System.Windows.Forms.Label();
            this.FooterLabel = new System.Windows.Forms.Label();
            this.GratBackgroundFooterLabel = new System.Windows.Forms.Label();
            this.CharityListHeaderLabel = new System.Windows.Forms.Label();
            this.CharityListTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
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
            this.HeaderLabel.TabIndex = 20;
            this.HeaderLabel.Text = "MARATHON SKILLS 2019";
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 19;
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
            this.GrayBackgroundLabel.TabIndex = 18;
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
            this.FooterLabel.TabIndex = 28;
            this.FooterLabel.Text = "Сколько-то дней до чего-то там";
            // 
            // GratBackgroundFooterLabel
            // 
            this.GratBackgroundFooterLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GratBackgroundFooterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GratBackgroundFooterLabel.Location = new System.Drawing.Point(0, 325);
            this.GratBackgroundFooterLabel.Name = "GratBackgroundFooterLabel";
            this.GratBackgroundFooterLabel.Size = new System.Drawing.Size(484, 36);
            this.GratBackgroundFooterLabel.TabIndex = 27;
            // 
            // CharityListHeaderLabel
            // 
            this.CharityListHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CharityListHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CharityListHeaderLabel.Location = new System.Drawing.Point(0, 48);
            this.CharityListHeaderLabel.Name = "CharityListHeaderLabel";
            this.CharityListHeaderLabel.Size = new System.Drawing.Size(484, 86);
            this.CharityListHeaderLabel.TabIndex = 29;
            this.CharityListHeaderLabel.Text = "Список благотворительных организаций\r\n\r\nЭто - список всех благотворительных учреж" +
    "дений, которые поддерживаются в Marathon Skills 2019. Спасибо за помощь вы подде" +
    "рживаете их, спонсируя бегунов!\r\n";
            this.CharityListHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CharityListTableLayoutPanel
            // 
            this.CharityListTableLayoutPanel.AutoScroll = true;
            this.CharityListTableLayoutPanel.AutoSize = true;
            this.CharityListTableLayoutPanel.ColumnCount = 2;
            this.CharityListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CharityListTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.CharityListTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharityListTableLayoutPanel.Location = new System.Drawing.Point(0, 134);
            this.CharityListTableLayoutPanel.Name = "CharityListTableLayoutPanel";
            this.CharityListTableLayoutPanel.RowCount = 2;
            this.CharityListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CharityListTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CharityListTableLayoutPanel.Size = new System.Drawing.Size(484, 191);
            this.CharityListTableLayoutPanel.TabIndex = 30;
            // 
            // MS_CharitiesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.CharityListTableLayoutPanel);
            this.Controls.Add(this.CharityListHeaderLabel);
            this.Controls.Add(this.FooterLabel);
            this.Controls.Add(this.GratBackgroundFooterLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.GrayBackgroundLabel);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MS_CharitiesList";
            this.Text = "MS_CharitiesList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Label GrayBackgroundLabel;
        private System.Windows.Forms.Label FooterLabel;
        private System.Windows.Forms.Label GratBackgroundFooterLabel;
        private System.Windows.Forms.Label CharityListHeaderLabel;
        private System.Windows.Forms.TableLayoutPanel CharityListTableLayoutPanel;
    }
}