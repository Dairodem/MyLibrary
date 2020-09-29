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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var booklist = ctx.Books.Select(x => x).ToList();
                lbxBooks.DisplayMember = "Titel";
                lbxBooks.ValueMember = "Id";
                lbxBooks.DataSource = booklist;
            }
        }

        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selector = Convert.ToInt32(lbxBooks.SelectedValue);
            lblData.Text = $"{selector}\n\n";

            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var book = ctx.Books.Where(b => b.Id == selector);

                var pubJoin = book
                    .Join(ctx.Publishers,
                    b => b.PublisherId,
                    p => p.Id,
                    (b, p) => new 
                    { b, p });

                foreach (var item in pubJoin)
                {

                    gbxData.Text = $"{item.b.Titel}";
                    lblData.Text += $"{item.b.AantalPaginas}\n\n";
                    lblData.Text += $"{item.b.publicatie}\n\n";
                    lblData.Text += $"{item.b.Score}\n\n";
                    lblData.Text += $"{item.p.Naam}";
                }
            }

        }
    }
}
