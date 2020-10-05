namespace MyLibrary
{
    partial class Form1
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
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.gbxData = new System.Windows.Forms.GroupBox();
            this.lbxGenres = new System.Windows.Forms.ListBox();
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPubl = new System.Windows.Forms.Label();
            this.lblPublYear = new System.Windows.Forms.Label();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxBooks
            // 
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 15;
            this.lbxBooks.Location = new System.Drawing.Point(12, 20);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(166, 304);
            this.lbxBooks.TabIndex = 0;
            this.lbxBooks.SelectedIndexChanged += new System.EventHandler(this.lbxBooks_SelectedIndexChanged);
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.lbxGenres);
            this.gbxData.Controls.Add(this.lbxAuthors);
            this.gbxData.Controls.Add(this.lblScore);
            this.gbxData.Controls.Add(this.lblPubl);
            this.gbxData.Controls.Add(this.lblPublYear);
            this.gbxData.Controls.Add(this.lblPages);
            this.gbxData.Controls.Add(this.btnChange);
            this.gbxData.Controls.Add(this.label4);
            this.gbxData.Controls.Add(this.label2);
            this.gbxData.Controls.Add(this.label1);
            this.gbxData.Controls.Add(this.lblid);
            this.gbxData.Location = new System.Drawing.Point(199, 14);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(244, 374);
            this.gbxData.TabIndex = 1;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "ThisBook";
            // 
            // lbxGenres
            // 
            this.lbxGenres.FormattingEnabled = true;
            this.lbxGenres.ItemHeight = 15;
            this.lbxGenres.Location = new System.Drawing.Point(101, 255);
            this.lbxGenres.Name = "lbxGenres";
            this.lbxGenres.Size = new System.Drawing.Size(120, 49);
            this.lbxGenres.TabIndex = 12;
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.ItemHeight = 15;
            this.lbxAuthors.Location = new System.Drawing.Point(101, 196);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(120, 49);
            this.lbxAuthors.TabIndex = 11;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(98, 126);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(15, 16);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "5";
            // 
            // lblPubl
            // 
            this.lblPubl.AutoSize = true;
            this.lblPubl.Location = new System.Drawing.Point(98, 158);
            this.lblPubl.Name = "lblPubl";
            this.lblPubl.Size = new System.Drawing.Size(37, 16);
            this.lblPubl.TabIndex = 9;
            this.lblPubl.Text = "publi";
            // 
            // lblPublYear
            // 
            this.lblPublYear.AutoSize = true;
            this.lblPublYear.Location = new System.Drawing.Point(98, 95);
            this.lblPublYear.Name = "lblPublYear";
            this.lblPublYear.Size = new System.Drawing.Size(36, 16);
            this.lblPublYear.TabIndex = 7;
            this.lblPublYear.Text = "1000";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(98, 63);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(47, 16);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "pages";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(6, 322);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(232, 37);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Bewerken...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Auteur(s):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre(s):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 144);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:\r\n\r\nPaginas:\r\n\r\nPublicatie:\r\n\r\nScore:\r\n\r\nUitgever:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(98, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "id";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAdd.Location = new System.Drawing.Point(205, 403);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Toevoegen...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Enabled = false;
            this.btnFilter.Location = new System.Drawing.Point(12, 385);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(167, 37);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filteren";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(10, 336);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(167, 37);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Verwijderen";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 477);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.lbxBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotheek";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxData.ResumeLayout(false);
            this.gbxData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBooks;
        private System.Windows.Forms.GroupBox gbxData;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lbxGenres;
        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPubl;
        private System.Windows.Forms.Label lblPublYear;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnRemove;
    }
}

