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
    public partial class FormFilter : Form
    {
        public int[] FilterData = new int[7];

        private string[] selectionTexts = new string[] { "precies", "tussen", "vanaf", "tot" };

        public FormFilter()
        {
            InitializeComponent();
        }
        private void FormFilter_Load(object sender, EventArgs e)
        {
            LoadData();
            DisableAllFields();
        }
        private void LoadData()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                //--combobox met auteurs vullen
                var authorList = ctx.Authors.Select(x => new { x.Id, Naam = x.Voornaam + " " + x.Achternaam }).ToList();
                cbxAuthors.DisplayMember = "Naam";
                cbxAuthors.ValueMember = "Id";
                cbxAuthors.DataSource = authorList;

                //--combobox met uitgevers vullen
                var pubList = ctx.Publishers.Select(x => x).ToList();
                cbxPublisher.DisplayMember = "Naam";
                cbxPublisher.ValueMember = "Id";
                cbxPublisher.DataSource = pubList;

                //-- combobox met genres vullen
                var genreList = ctx.Genres.Select(x => x).ToList();
                cbxGenres.DisplayMember = "Genre1";
                cbxGenres.ValueMember = "Id";
                cbxGenres.DataSource = genreList;

                //-- combobox met publicatie selectie vullen
                cbxPubl.Items.AddRange(selectionTexts);
                cbxPubl.SelectedIndex = 0;

                //-- combobox met Score selectie vullen
                cbxScore.Items.AddRange(selectionTexts);
                cbxScore.SelectedIndex = 0;
            }
        }
        private void DisableAllFields()
        {
            cbxScore.Enabled = false;
            numScoreLow.Enabled = false;
            numScoreHigh.Enabled = false;
            lblScoreSign.Enabled = false;
            cbxPubl.Enabled = false;
            numYearLow.Enabled = false;
            numYearHigh.Enabled = false;
            lblPubSign.Enabled = false;
            cbxGenres.Enabled = false;
            cbxPublisher.Enabled = false;
            cbxAuthors.Enabled = false;
        }

        private void chkAuthor_CheckedChanged(object sender, EventArgs e)
        {
            cbxAuthors.Enabled = chkAuthor.Checked;
        }
        private void chkPublisher_CheckedChanged(object sender, EventArgs e)
        {
            cbxPublisher.Enabled = chkPublisher.Checked;
        }
        private void chkGenre_CheckedChanged(object sender, EventArgs e)
        {
            cbxGenres.Enabled = chkGenre.Checked;
        }
        private void chkPubl_CheckedChanged(object sender, EventArgs e)
        {
            cbxPubl.Enabled = chkPubl.Checked;
            numYearLow.Enabled = chkPubl.Checked;
            numYearHigh.Enabled = chkPubl.Checked;
            lblPubSign.Enabled = chkPubl.Checked;

        }
        private void chkScore_CheckedChanged(object sender, EventArgs e)
        {
            cbxScore.Enabled = chkScore.Checked;
            numScoreLow.Enabled = chkScore.Checked;
            numScoreHigh.Enabled = chkScore.Checked;
            lblScoreSign.Enabled = chkScore.Checked;
        }
        private void cbxPubl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxPubl.SelectedItem.ToString())
            {
                case "tussen":
                    numYearLow.Visible = true;
                    lblPubSign.Text = "en";
                    break;
                case "precies":
                case "vanaf":
                case "tot":
                    numYearLow.Visible = false;
                    lblPubSign.Text = "";
                    break;
                default:
                    break;
            }
        }
        private void cbxScore_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxScore.SelectedItem.ToString())
            {
                case "tussen":
                    numScoreLow.Visible = true;
                    lblScoreSign.Text = "en";
                    break;
                case "precies":
                case "vanaf":
                case "tot":
                    numScoreLow.Visible = false;
                    lblScoreSign.Text = "";
                    break;
                default:
                    break;
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterData[0] = chkAuthor.Checked ? (int)cbxAuthors.SelectedValue : -1;
            FilterData[1] = chkPublisher.Checked ? (int)cbxPublisher.SelectedValue : -1;
            FilterData[2] = chkGenre.Checked ? (int)cbxGenres.SelectedValue : -1;
            FilterData[3] = chkPubl.Checked ? (int)numYearLow.Value : -1;
            FilterData[4] = chkPubl.Checked ? (int)numYearHigh.Value : -1;
            FilterData[5] = chkScore.Checked ? (int)numScoreLow.Value : -1;
            FilterData[6] = chkScore.Checked ? (int)numScoreHigh.Value : -1;


            DialogResult = DialogResult.OK;
        }
    }
}
