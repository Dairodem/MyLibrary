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
            this.lblAuthors = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.gbxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxBooks
            // 
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 15;
            this.lbxBooks.Location = new System.Drawing.Point(14, 14);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(166, 319);
            this.lbxBooks.TabIndex = 0;
            this.lbxBooks.SelectedIndexChanged += new System.EventHandler(this.lbxBooks_SelectedIndexChanged);
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.lblAuthors);
            this.gbxData.Controls.Add(this.label4);
            this.gbxData.Controls.Add(this.lblGenre);
            this.gbxData.Controls.Add(this.label2);
            this.gbxData.Controls.Add(this.label1);
            this.gbxData.Controls.Add(this.lblData);
            this.gbxData.Location = new System.Drawing.Point(199, 14);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(244, 320);
            this.gbxData.TabIndex = 1;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "ThisBook";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Location = new System.Drawing.Point(98, 192);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(45, 16);
            this.lblAuthors.TabIndex = 5;
            this.lblAuthors.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Auteur(s):";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(98, 251);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(45, 16);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
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
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(98, 30);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(45, 16);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "label1";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnAdd.Location = new System.Drawing.Point(199, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(244, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Toevoegen...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(199, 384);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(244, 37);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Bewerken...";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(14, 340);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(167, 37);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "Filteren";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 433);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnChange);
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
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnFilter;
    }
}

