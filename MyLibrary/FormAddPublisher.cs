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
    public partial class FormAddPublisher : Form
    {
        public FormAddPublisher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                ctx.Publishers.Add(new Publisher() { Naam = txtName.Text });
                ctx.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
    }
}
