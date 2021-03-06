﻿using System;
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
        public int Id;
        public int PublisherId;
        public int Year;
        public int Pages;
        public int Score;
        public bool IsChanging;
        public List<string> AuthorsList = new List<string>();
        public List<string> GenreList = new List<string>();

        public FormAddBook(bool isChanging)
        {
            IsChanging = isChanging;
            InitializeComponent();
        }
        private void FormAddBook_Load(object sender, EventArgs e)
        {
            LoadPublisherList();
            LoadAuthorList();
            LoadGenreList();

            if (IsChanging)
            {
                ChangeTexts();
                CheckBoxes(lvAuthors,AuthorsList);
                CheckBoxes(lvGenres, GenreList);
            }

        }
        private void ChangeTexts()
        {
            Text = "Boek Bewerken...";
            BtnAdd.Text = "Bewerk";
            txtTitle.Text = Title;
            numPages.Value = Pages;
            numYear.Value = Year;
            numScore.Value = Score;
            cbxPublisher.SelectedValue = PublisherId;
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
        private void LoadAuthorList()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var autList = ctx.Authors.Select(x => new { x.Id, Naam = x.Voornaam + " " + x.Achternaam }).ToList();
                foreach (var author in autList)
                {
                    lvAuthors.Items.Add(author.Naam);
                }
            }

        }
        private void LoadGenreList()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                var genreList = ctx.Genres.Select(x => x).ToList();
                foreach (var genre in genreList)
                {
                    lvGenres.Items.Add(genre.Genre1);
                }

            }
        }
        private void AddNewBook()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                //--Nieuw boek aanmaken
                Book newBook = new Book()
                {
                    Titel = txtTitle.Text,
                    AantalPaginas = (int)numPages.Value,
                    publicatie = (int)numYear.Value,
                    PublisherId = (int)cbxPublisher.SelectedValue,
                    Score = (int)numScore.Value
                };
                ctx.Books.Add(newBook);
                ctx.SaveChanges();

                //--Nieuw Book-Auteur Tussentabel  entry voor elke auteur
                foreach (ListViewItem author in lvAuthors.CheckedItems)
                {
                    int entry = ctx.Authors.Where(a => (a.Voornaam + " " + a.Achternaam) == author.Text).Select(x => x.Id).FirstOrDefault();

                    ctx.BookAuthors.Add(new BookAuthor()
                    {
                        BookId = newBook.Id,
                        AuthorId = entry
                    });
                }

                //--Nieuw Book-Genre Tussentabel  entry voor elk genre
                foreach (ListViewItem genre in lvGenres.CheckedItems)
                {
                    int entry = ctx.Genres.Where(a => a.Genre1 == genre.Text).Select(x => x.Id).FirstOrDefault();

                    ctx.BookGenres.Add(new BookGenre()
                    {
                        BookId = newBook.Id,
                        GenreId = entry
                    });
                }
                ctx.SaveChanges();
            }

        }
        private void ChangeBook()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                //--Boek selecteren met Id...
                Book thisBook = ctx.Books.Where(x => x.Id == Id).FirstOrDefault();

                //--alle links van dit boek-id in tussentabel naar lijst (boekgenres en boekauteurs) 
                List<BookAuthor> authorLink = ctx.BookAuthors.Where(x => x.BookId == Id).ToList();
                List<BookGenre> genresLink = ctx.BookGenres.Where(x => x.BookId == Id).ToList();

                //--verwijder alle links van dit boek in tussentabellen
                foreach (BookAuthor link in authorLink)
                {
                    ctx.BookAuthors.Remove(link);
                }
                foreach (BookGenre link in genresLink)
                {
                    ctx.BookGenres.Remove(link);
                }

                //--Reset gegevens van dit boek
                thisBook.Titel = txtTitle.Text;
                thisBook.Score = (int)numScore.Value;
                thisBook.publicatie = (int)numYear.Value;
                thisBook.PublisherId = (int)cbxPublisher.SelectedValue;
                thisBook.AantalPaginas = (int)numPages.Value;


                //--Nieuw Book-Auteur Tussentabel  entry voor elke auteur
                foreach (ListViewItem author in lvAuthors.CheckedItems)
                {
                    int entry = ctx.Authors.Where(a => (a.Voornaam + " " + a.Achternaam) == author.Text).Select(x => x.Id).FirstOrDefault();

                    ctx.BookAuthors.Add(new BookAuthor()
                    {
                        BookId = thisBook.Id,
                        AuthorId = entry
                    });
                }

                //--Nieuw Book-Genre Tussentabel  entry voor elk genre
                foreach (ListViewItem genre in lvGenres.CheckedItems)
                {
                    int entry = ctx.Genres.Where(a => a.Genre1 == genre.Text).Select(x => x.Id).FirstOrDefault();

                    ctx.BookGenres.Add(new BookGenre()
                    {
                        BookId = thisBook.Id,
                        GenreId = entry
                    });
                }

                ctx.SaveChanges();
            }

        }
        private void CheckBoxes(ListView listView, List<string> list)
        {
            foreach (string name in list)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    if (name == item.Text)
                    {
                        item.Checked = true;
                        break;
                    }
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (IsChanging)
            {
                ChangeBook();
            }
            else
            {
                AddNewBook();
            }

            DialogResult = DialogResult.OK;
        }

    }
}
