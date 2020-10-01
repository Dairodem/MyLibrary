﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*------------------------ TO DO ------------------------------
 * 
 * bij elke addform een result = ok op btnAdd
 * switch inorde brengen
 * testen van de add functies
 * 
 * 
 * toevoegen van uitgever
 * toevoegen van auteurs
 * toevoegen van genres
 * 
 * 
 * 
 * bewerken van boeken
 * sorteren van boekenlijst
 * (meerdere) filters toepassen
 * 
 * error handeling
 * 
 * ------------------------------------------------------------
 */

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
            LoadBookList();
        }
        private void UpdateData()
        {
            int selector = Convert.ToInt32(lbxBooks.SelectedValue);
            lblData.Text = $"{selector}\n\n";
            lblAuthors.Text = "";
            lblGenre.Text = "";
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var book = ctx.Books.Where(b => b.Id == selector);

                //---Join Book with Publisher
                var pubJoin = book
                    .Join(ctx.Publishers,
                    b => b.PublisherId,
                    p => p.Id,
                    (b, p) => new
                    { b, p });

                //--Join Book with Genre
                var genreJoin = book
                    .Join(ctx.BookGenres,
                    b => b.Id,
                    bg => bg.BookId,
                    (b, bg) => new { b, bg })
                    .Join(ctx.Genres,
                    bg2 => bg2.bg.GenreId,
                    g => g.Id,
                    (bg2, g) => new { bg2, g });

                //--Join Book with Authors
                var authorJoin = book
                    .Join(ctx.BookAuthors,
                    b => b.Id,
                    ba => ba.BookId,
                    (b, ba) => new { b, ba })
                    .Join(ctx.Authors,
                    ba2 => ba2.ba.AuthorId,
                    a => a.Id,
                    (ba2, a) => new { ba2, a });


                foreach (var item in pubJoin)
                {

                    gbxData.Text = $"{item.b.Titel}";
                    lblData.Text += $"{item.b.AantalPaginas}\n\n";
                    lblData.Text += $"{item.b.publicatie}\n\n";
                    lblData.Text += $"{item.b.Score}\n\n";
                    lblData.Text += $"{item.p.Naam}";
                }
                foreach (var item in genreJoin)
                {
                    lblGenre.Text += $"{item.g.Genre1}\n";
                }
                foreach (var item in authorJoin)
                {
                    lblAuthors.Text += $"{item.a.Voornaam} {item.a.Achternaam}\n";
                }
            }

        }
        private void LoadBookList()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var booklist = ctx.Books.Select(x => x).ToList();
                lbxBooks.DisplayMember = "Titel";
                lbxBooks.ValueMember = "Id";
                lbxBooks.DataSource = booklist;
            }
        }
        private void ShowSelectionForm()
        {
            FormAdd formAdd = new FormAdd();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                switch (formAdd.Selection)
                {
                    case "Boek":
                        ShowBookForm();
                        break;
                    case "Auteur":
                        ShowAuthorForm();
                        break;
                    case "Genre":
                        ShowGenreForm();
                        break;
                    case "Uitgeverij":
                        ShowPublisherForm();
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
            }

        }
        private void ShowBookForm()
        {
            FormAddBook formAddBook = new FormAddBook();
            if (formAddBook.ShowDialog() == DialogResult.OK)
            {
                LoadBookList();
            }

        }
        private void ShowAuthorForm()
        {
            FormAddAuthor formAddAuthor = new FormAddAuthor();
            if (formAddAuthor.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void ShowGenreForm()
        {
            FormAddGenre formAddGenre = new FormAddGenre();
            if (formAddGenre.ShowDialog() == DialogResult.OK)
            {

            }
        }
        private void ShowPublisherForm()
        {
            FormAddPublisher formAddPublisher = new FormAddPublisher();
            if (formAddPublisher.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSelectionForm();
        }
    }
}
