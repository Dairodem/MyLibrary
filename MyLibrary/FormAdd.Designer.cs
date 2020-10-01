namespace MyLibrary
{
    partial class FormAdd
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
            this.cbxAddList = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxAddList
            // 
            this.cbxAddList.FormattingEnabled = true;
            this.cbxAddList.Location = new System.Drawing.Point(20, 45);
            this.cbxAddList.Name = "cbxAddList";
            this.cbxAddList.Size = new System.Drawing.Size(140, 23);
            this.cbxAddList.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(20, 86);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 29);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wat wilt u toevoegen?";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxAddList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Toevoegen...";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAddList;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
    }
}