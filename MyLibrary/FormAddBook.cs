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
    public partial class FormAddBook : Form
    {

        public string Title;
        public int PublisherId;
        public int Year;
        public int Pages;
        public int Score;

        public FormAddBook()
        {
            InitializeComponent();
        }
        private void FormAddBook_Load(object sender, EventArgs e)
        {
            LoadPublisherList();
        }
        private void LoadPublisherList()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var PubList = ctx.Publishers.Select(x => x).ToList();
                cbxPublisher.DisplayMember = "Naam";
                cbxPublisher.ValueMember = "Id";
                cbxPublisher.DataSource = PubList;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Title = txtTitle.Text;
            PublisherId = (int)cbxPublisher.SelectedValue;
            Year = (int)numYear.Value;
            Pages = (int)numPages.Value;
            Score = (int)numScore.Value;

            DialogResult = DialogResult.OK;
        }

    }
}
