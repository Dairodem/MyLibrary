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
                var pubJoin = ctx.Books
                    .Join(ctx.Publishers,
                    b => b.PublisherId,
                    p => p.Id,
                    (b, p) => new { b.PublisherId, p });
                
                foreach (var item in book)
                {
                    gbxData.Text = item.Titel;
                    lblData.Text += $"{item.AantalPaginas}\n\n";
                    lblData.Text += $"{item.publicatie}\n\n";
                    lblData.Text += $"{item.Score}\n\n";
                    lblData.Text += $"{item.PublisherId}"; // needs to be the name of publisher through join
                }
            }
        }
    }
}
