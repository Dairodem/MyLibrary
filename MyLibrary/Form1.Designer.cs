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
            this.lblData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxBooks
            // 
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.Location = new System.Drawing.Point(12, 12);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(143, 277);
            this.lbxBooks.TabIndex = 0;
            this.lbxBooks.SelectedIndexChanged += new System.EventHandler(this.lbxBooks_SelectedIndexChanged);
            // 
            // gbxData
            // 
            this.gbxData.Controls.Add(this.label1);
            this.gbxData.Controls.Add(this.lblData);
            this.gbxData.Location = new System.Drawing.Point(171, 12);
            this.gbxData.Name = "gbxData";
            this.gbxData.Size = new System.Drawing.Size(146, 162);
            this.gbxData.TabIndex = 1;
            this.gbxData.TabStop = false;
            this.gbxData.Text = "ThisBook";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(84, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 117);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:\r\n\r\nPaginas:\r\n\r\nPublicate:\r\n\r\nScore:\r\n\r\nUitgever:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 298);
            this.Controls.Add(this.gbxData);
            this.Controls.Add(this.lbxBooks);
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
    }
}

