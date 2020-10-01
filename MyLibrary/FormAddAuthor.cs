using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class FormAddAuthor : Form
    {
        public FormAddAuthor()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                ctx.Authors.Add(new Author() { Voornaam = txtName.Text, Achternaam = txtFname.Text });
                ctx.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }

    }
}
