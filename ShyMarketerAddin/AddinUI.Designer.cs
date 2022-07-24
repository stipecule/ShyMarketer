namespace ShyMarketerAddin
{
    partial class AddinUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCompanySector = new System.Windows.Forms.ComboBox();
            this.textBoxAboutCompanyText = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCompanyLink = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtBoxCompanyName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCallAPI = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.comboBoxTargetAudience = new System.Windows.Forms.ComboBox();
            this.textBoxArticleText = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxArticlePunchLine = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxArticleTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 95);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Shy Marketer!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Easily share your idea or a product with open source community!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxCompanySector);
            this.groupBox1.Controls.Add(this.textBoxAboutCompanyText);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxCompanyLink);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.txtBoxCompanyName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 444);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tell us about yourself!";
            // 
            // comboBoxCompanySector
            // 
            this.comboBoxCompanySector.FormattingEnabled = true;
            this.comboBoxCompanySector.Items.AddRange(new object[] {
            "IT",
            "Marketing",
            "Health",
            "Engineering",
            "Entertainment",
            "Education",
            "Agriculture",
            "Fashion",
            "Finance and economic",
            "Media and News",
            "Telecommunication"});
            this.comboBoxCompanySector.Location = new System.Drawing.Point(135, 130);
            this.comboBoxCompanySector.Name = "comboBoxCompanySector";
            this.comboBoxCompanySector.Size = new System.Drawing.Size(179, 21);
            this.comboBoxCompanySector.TabIndex = 14;
            // 
            // textBoxAboutCompanyText
            // 
            this.textBoxAboutCompanyText.Location = new System.Drawing.Point(9, 195);
            this.textBoxAboutCompanyText.Name = "textBoxAboutCompanyText";
            this.textBoxAboutCompanyText.Size = new System.Drawing.Size(661, 243);
            this.textBoxAboutCompanyText.TabIndex = 13;
            this.textBoxAboutCompanyText.Text = "";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Company Sector:";
            // 
            // textBoxCompanyLink
            // 
            this.textBoxCompanyLink.Location = new System.Drawing.Point(135, 83);
            this.textBoxCompanyLink.Name = "textBoxCompanyLink";
            this.textBoxCompanyLink.Size = new System.Drawing.Size(535, 23);
            this.textBoxCompanyLink.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Company Link:";
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Location = new System.Drawing.Point(6, 38);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(123, 23);
            this.lblCompanyName.TabIndex = 8;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(135, 38);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(535, 23);
            this.txtBoxCompanyName.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 476);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Company Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.pictureBox);
            this.tabPage2.Controls.Add(this.kryptonButton1);
            this.tabPage2.Controls.Add(this.btnCallAPI);
            this.tabPage2.Controls.Add(this.comboBoxTargetAudience);
            this.tabPage2.Controls.Add(this.textBoxArticleText);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxArticlePunchLine);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBoxArticleTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marketing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(463, 93);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(207, 76);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 19;
            this.pictureBox.TabStop = false;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(339, 110);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(110, 26);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 5;
            this.kryptonButton1.TabIndex = 17;
            this.kryptonButton1.Values.Text = "Select an image";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Location = new System.Drawing.Point(194, 410);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(255, 34);
            this.btnCallAPI.StateCommon.Back.Color1 = System.Drawing.Color.LightGreen;
            this.btnCallAPI.StateCommon.Back.Color2 = System.Drawing.Color.LightGreen;
            this.btnCallAPI.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnCallAPI.StateCommon.Border.Rounding = 5;
            this.btnCallAPI.TabIndex = 16;
            this.btnCallAPI.Values.Text = "Let\'s market!!";
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // comboBoxTargetAudience
            // 
            this.comboBoxTargetAudience.FormattingEnabled = true;
            this.comboBoxTargetAudience.Items.AddRange(new object[] {
            "IT",
            "Marketing",
            "Health",
            "Engineering",
            "Entertainment",
            "Education",
            "Agriculture",
            "Fashion",
            "Finance and economic",
            "Media and News",
            "Telecommunication"});
            this.comboBoxTargetAudience.Location = new System.Drawing.Point(135, 110);
            this.comboBoxTargetAudience.Name = "comboBoxTargetAudience";
            this.comboBoxTargetAudience.Size = new System.Drawing.Size(179, 21);
            this.comboBoxTargetAudience.TabIndex = 15;
            // 
            // textBoxArticleText
            // 
            this.textBoxArticleText.Location = new System.Drawing.Point(9, 175);
            this.textBoxArticleText.Name = "textBoxArticleText";
            this.textBoxArticleText.Size = new System.Drawing.Size(661, 213);
            this.textBoxArticleText.TabIndex = 13;
            this.textBoxArticleText.Text = "";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Target Sector:";
            // 
            // textBoxArticlePunchLine
            // 
            this.textBoxArticlePunchLine.Location = new System.Drawing.Point(135, 63);
            this.textBoxArticlePunchLine.Name = "textBoxArticlePunchLine";
            this.textBoxArticlePunchLine.Size = new System.Drawing.Size(535, 23);
            this.textBoxArticlePunchLine.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Article Punchline:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Article Title:";
            // 
            // textBoxArticleTitle
            // 
            this.textBoxArticleTitle.Location = new System.Drawing.Point(135, 18);
            this.textBoxArticleTitle.Name = "textBoxArticleTitle";
            this.textBoxArticleTitle.Size = new System.Drawing.Size(535, 23);
            this.textBoxArticleTitle.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Some wanna know facts about you, your company, goals, ambitions...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Main text of your advertising article";
            // 
            // AddinUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AddinUI";
            this.Size = new System.Drawing.Size(1000, 476);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblCompanyName;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBoxCompanyName;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxCompanyLink;
        public System.Windows.Forms.ComboBox comboBoxCompanySector;
        public ComponentFactory.Krypton.Toolkit.KryptonRichTextBox textBoxAboutCompanyText;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxArticleTitle;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxArticlePunchLine;
        public System.Windows.Forms.ComboBox comboBoxTargetAudience;
        public ComponentFactory.Krypton.Toolkit.KryptonRichTextBox textBoxArticleText;
        public ComponentFactory.Krypton.Toolkit.KryptonButton btnCallAPI;
        public ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}
