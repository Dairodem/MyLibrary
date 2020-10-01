namespace MyLibrary
{
    partial class FormAddBook
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.numPages = new System.Windows.Forms.NumericUpDown();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvAuthors = new System.Windows.Forms.ListView();
            this.lvGenres = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(100, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(37, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Titel:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(169, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(193, 21);
            this.txtTitle.TabIndex = 1;
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(169, 208);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(193, 23);
            this.cbxPublisher.TabIndex = 2;
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(169, 240);
            this.numYear.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(194, 21);
            this.numYear.TabIndex = 3;
            this.numYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numYear.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // numPages
            // 
            this.numPages.Location = new System.Drawing.Point(169, 270);
            this.numPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPages.Name = "numPages";
            this.numPages.Size = new System.Drawing.Size(194, 21);
            this.numPages.TabIndex = 4;
            this.numPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numScore
            // 
            this.numScore.Location = new System.Drawing.Point(169, 300);
            this.numScore.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numScore.Name = "numScore";
            this.numScore.Size = new System.Drawing.Size(194, 21);
            this.numScore.TabIndex = 5;
            this.numScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numScore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Uitgever:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Publicatiejaar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aantal pagina\'s:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Score:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(169, 327);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(194, 28);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "Voeg toe";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Auteur(s):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre(s):";
            // 
            // lvAuthors
            // 
            this.lvAuthors.CheckBoxes = true;
            this.lvAuthors.FullRowSelect = true;
            this.lvAuthors.HideSelection = false;
            this.lvAuthors.Location = new System.Drawing.Point(169, 54);
            this.lvAuthors.Name = "lvAuthors";
            this.lvAuthors.ShowGroups = false;
            this.lvAuthors.Size = new System.Drawing.Size(193, 74);
            this.lvAuthors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvAuthors.TabIndex = 15;
            this.lvAuthors.UseCompatibleStateImageBehavior = false;
            this.lvAuthors.View = System.Windows.Forms.View.SmallIcon;
            // 
            // lvGenres
            // 
            this.lvGenres.CheckBoxes = true;
            this.lvGenres.HideSelection = false;
            this.lvGenres.Location = new System.Drawing.Point(169, 134);
            this.lvGenres.Name = "lvGenres";
            this.lvGenres.Size = new System.Drawing.Size(193, 68);
            this.lvGenres.TabIndex = 16;
            this.lvGenres.UseCompatibleStateImageBehavior = false;
            this.lvGenres.View = System.Windows.Forms.View.SmallIcon;
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 366);
            this.Controls.Add(this.lvGenres);
            this.Controls.Add(this.lvAuthors);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.numPages);
            this.Controls.Add(this.numYear);
            this.Controls.Add(this.cbxPublisher);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boek Toevoegen";
            this.Load += new System.EventHandler(this.FormAddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.NumericUpDown numPages;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvAuthors;
        private System.Windows.Forms.ListView lvGenres;
    }
}