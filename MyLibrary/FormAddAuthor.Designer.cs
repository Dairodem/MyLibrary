namespace MyLibrary
{
    partial class FormAddAuthor
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 21);
            this.txtName.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(51, 32);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Voornaam:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(131, 60);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(224, 21);
            this.txtFname.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Achternaam:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(131, 100);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(224, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Voeg toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 141);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormAddAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Auteur Toevoegen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
    }
}