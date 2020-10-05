namespace MyLibrary
{
    partial class FormFilter
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
            this.numYearLow = new System.Windows.Forms.NumericUpDown();
            this.numYearHigh = new System.Windows.Forms.NumericUpDown();
            this.cbxPublisher = new System.Windows.Forms.ComboBox();
            this.chkAuthor = new System.Windows.Forms.CheckBox();
            this.chkPublisher = new System.Windows.Forms.CheckBox();
            this.chkGenre = new System.Windows.Forms.CheckBox();
            this.cbxAuthors = new System.Windows.Forms.ComboBox();
            this.chkPubl = new System.Windows.Forms.CheckBox();
            this.cbxPubl = new System.Windows.Forms.ComboBox();
            this.lblPubSign = new System.Windows.Forms.Label();
            this.chkScore = new System.Windows.Forms.CheckBox();
            this.lblScoreSign = new System.Windows.Forms.Label();
            this.cbxScore = new System.Windows.Forms.ComboBox();
            this.numScoreLow = new System.Windows.Forms.NumericUpDown();
            this.numScoreHigh = new System.Windows.Forms.NumericUpDown();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbxGenres = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numYearLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearHigh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreLow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // numYearLow
            // 
            this.numYearLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.numYearLow.Location = new System.Drawing.Point(163, 148);
            this.numYearLow.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numYearLow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYearLow.Name = "numYearLow";
            this.numYearLow.Size = new System.Drawing.Size(57, 21);
            this.numYearLow.TabIndex = 12;
            this.numYearLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numYearLow.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numYearHigh
            // 
            this.numYearHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.numYearHigh.Location = new System.Drawing.Point(255, 148);
            this.numYearHigh.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numYearHigh.Name = "numYearHigh";
            this.numYearHigh.Size = new System.Drawing.Size(57, 21);
            this.numYearHigh.TabIndex = 11;
            this.numYearHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numYearHigh.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // cbxPublisher
            // 
            this.cbxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbxPublisher.FormattingEnabled = true;
            this.cbxPublisher.Location = new System.Drawing.Point(137, 60);
            this.cbxPublisher.Name = "cbxPublisher";
            this.cbxPublisher.Size = new System.Drawing.Size(175, 23);
            this.cbxPublisher.TabIndex = 10;
            // 
            // chkAuthor
            // 
            this.chkAuthor.AutoSize = true;
            this.chkAuthor.Location = new System.Drawing.Point(34, 32);
            this.chkAuthor.Name = "chkAuthor";
            this.chkAuthor.Size = new System.Drawing.Size(65, 20);
            this.chkAuthor.TabIndex = 18;
            this.chkAuthor.Text = "Auteur";
            this.chkAuthor.UseVisualStyleBackColor = true;
            this.chkAuthor.CheckedChanged += new System.EventHandler(this.chkAuthor_CheckedChanged);
            // 
            // chkPublisher
            // 
            this.chkPublisher.AutoSize = true;
            this.chkPublisher.Location = new System.Drawing.Point(34, 61);
            this.chkPublisher.Name = "chkPublisher";
            this.chkPublisher.Size = new System.Drawing.Size(81, 20);
            this.chkPublisher.TabIndex = 19;
            this.chkPublisher.Text = "Uigeverij";
            this.chkPublisher.UseVisualStyleBackColor = true;
            this.chkPublisher.CheckedChanged += new System.EventHandler(this.chkPublisher_CheckedChanged);
            // 
            // chkGenre
            // 
            this.chkGenre.AutoSize = true;
            this.chkGenre.Location = new System.Drawing.Point(34, 90);
            this.chkGenre.Name = "chkGenre";
            this.chkGenre.Size = new System.Drawing.Size(64, 20);
            this.chkGenre.TabIndex = 20;
            this.chkGenre.Text = "Genre";
            this.chkGenre.UseVisualStyleBackColor = true;
            this.chkGenre.CheckedChanged += new System.EventHandler(this.chkGenre_CheckedChanged);
            // 
            // cbxAuthors
            // 
            this.cbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbxAuthors.FormattingEnabled = true;
            this.cbxAuthors.Location = new System.Drawing.Point(137, 31);
            this.cbxAuthors.Name = "cbxAuthors";
            this.cbxAuthors.Size = new System.Drawing.Size(175, 23);
            this.cbxAuthors.TabIndex = 22;
            // 
            // chkPubl
            // 
            this.chkPubl.AutoSize = true;
            this.chkPubl.Location = new System.Drawing.Point(34, 120);
            this.chkPubl.Name = "chkPubl";
            this.chkPubl.Size = new System.Drawing.Size(86, 20);
            this.chkPubl.TabIndex = 23;
            this.chkPubl.Text = "Publicatie";
            this.chkPubl.UseVisualStyleBackColor = true;
            this.chkPubl.CheckedChanged += new System.EventHandler(this.chkPubl_CheckedChanged);
            // 
            // cbxPubl
            // 
            this.cbxPubl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbxPubl.FormattingEnabled = true;
            this.cbxPubl.Location = new System.Drawing.Point(137, 119);
            this.cbxPubl.Name = "cbxPubl";
            this.cbxPubl.Size = new System.Drawing.Size(175, 23);
            this.cbxPubl.TabIndex = 24;
            this.cbxPubl.SelectedIndexChanged += new System.EventHandler(this.cbxPubl_SelectedIndexChanged);
            // 
            // lblPubSign
            // 
            this.lblPubSign.AutoSize = true;
            this.lblPubSign.Location = new System.Drawing.Point(226, 150);
            this.lblPubSign.Name = "lblPubSign";
            this.lblPubSign.Size = new System.Drawing.Size(22, 16);
            this.lblPubSign.TabIndex = 25;
            this.lblPubSign.Text = "tot";
            // 
            // chkScore
            // 
            this.chkScore.AutoSize = true;
            this.chkScore.Location = new System.Drawing.Point(34, 192);
            this.chkScore.Name = "chkScore";
            this.chkScore.Size = new System.Drawing.Size(63, 20);
            this.chkScore.TabIndex = 26;
            this.chkScore.Text = "Score";
            this.chkScore.UseVisualStyleBackColor = true;
            this.chkScore.CheckedChanged += new System.EventHandler(this.chkScore_CheckedChanged);
            // 
            // lblScoreSign
            // 
            this.lblScoreSign.AutoSize = true;
            this.lblScoreSign.Location = new System.Drawing.Point(226, 222);
            this.lblScoreSign.Name = "lblScoreSign";
            this.lblScoreSign.Size = new System.Drawing.Size(22, 16);
            this.lblScoreSign.TabIndex = 30;
            this.lblScoreSign.Text = "tot";
            // 
            // cbxScore
            // 
            this.cbxScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbxScore.FormattingEnabled = true;
            this.cbxScore.Location = new System.Drawing.Point(137, 191);
            this.cbxScore.Name = "cbxScore";
            this.cbxScore.Size = new System.Drawing.Size(175, 23);
            this.cbxScore.TabIndex = 29;
            this.cbxScore.SelectedIndexChanged += new System.EventHandler(this.cbxScore_SelectedIndexChanged);
            // 
            // numScoreLow
            // 
            this.numScoreLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.numScoreLow.Location = new System.Drawing.Point(163, 220);
            this.numScoreLow.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numScoreLow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numScoreLow.Name = "numScoreLow";
            this.numScoreLow.Size = new System.Drawing.Size(57, 21);
            this.numScoreLow.TabIndex = 28;
            this.numScoreLow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numScoreLow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numScoreHigh
            // 
            this.numScoreHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.numScoreHigh.Location = new System.Drawing.Point(255, 220);
            this.numScoreHigh.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numScoreHigh.Name = "numScoreHigh";
            this.numScoreHigh.Size = new System.Drawing.Size(57, 21);
            this.numScoreHigh.TabIndex = 27;
            this.numScoreHigh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numScoreHigh.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(137, 258);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(175, 36);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "Go!";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbxGenres
            // 
            this.cbxGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.cbxGenres.FormattingEnabled = true;
            this.cbxGenres.Location = new System.Drawing.Point(137, 90);
            this.cbxGenres.Name = "cbxGenres";
            this.cbxGenres.Size = new System.Drawing.Size(175, 23);
            this.cbxGenres.TabIndex = 32;
            // 
            // FormFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 306);
            this.Controls.Add(this.cbxGenres);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblScoreSign);
            this.Controls.Add(this.cbxScore);
            this.Controls.Add(this.numScoreLow);
            this.Controls.Add(this.numScoreHigh);
            this.Controls.Add(this.chkScore);
            this.Controls.Add(this.lblPubSign);
            this.Controls.Add(this.cbxPubl);
            this.Controls.Add(this.chkPubl);
            this.Controls.Add(this.cbxAuthors);
            this.Controls.Add(this.chkGenre);
            this.Controls.Add(this.chkPublisher);
            this.Controls.Add(this.chkAuthor);
            this.Controls.Add(this.numYearLow);
            this.Controls.Add(this.numYearHigh);
            this.Controls.Add(this.cbxPublisher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormFilter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filters";
            this.Load += new System.EventHandler(this.FormFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYearLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYearHigh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreLow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScoreHigh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numYearLow;
        private System.Windows.Forms.NumericUpDown numYearHigh;
        private System.Windows.Forms.ComboBox cbxPublisher;
        private System.Windows.Forms.CheckBox chkAuthor;
        private System.Windows.Forms.CheckBox chkPublisher;
        private System.Windows.Forms.CheckBox chkGenre;
        private System.Windows.Forms.ComboBox cbxAuthors;
        private System.Windows.Forms.CheckBox chkPubl;
        private System.Windows.Forms.ComboBox cbxPubl;
        private System.Windows.Forms.Label lblPubSign;
        private System.Windows.Forms.CheckBox chkScore;
        private System.Windows.Forms.Label lblScoreSign;
        private System.Windows.Forms.ComboBox cbxScore;
        private System.Windows.Forms.NumericUpDown numScoreLow;
        private System.Windows.Forms.NumericUpDown numScoreHigh;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbxGenres;
    }
}