using System;
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
 * sorteren van boekenlijst
 * 
 * 
 * (meerdere) filters toepassen
 * UpdateData method herbekijken
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
            lblid.Text = $"{selector}";
            lbxAuthors.Items.Clear();
            lbxGenres.Items.Clear();

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
                    lblPages.Text = $"{item.b.AantalPaginas}";
                    lblPublYear.Text = $"{item.b.publicatie}";
                    lblScore.Text = $"{item.b.Score}";
                    lblPubl.Text = $"{item.p.Naam}";
                }
                foreach (var item in genreJoin)
                {
                    lbxGenres.Items.Add(item.g.Genre1);
                }
                foreach (var item in authorJoin)
                {
                    lbxAuthors.Items.Add($"{item.a.Voornaam} {item.a.Achternaam}");
                }
            }

        }
        private void DeleteBook()
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                //--selectie uit listbox opslaan
                int myId = (int)lbxBooks.SelectedValue;

                //--Boek selecteren obv myId en verwijderen
                Book thisBook = ctx.Books.Where(x => x.Id == myId).FirstOrDefault();
                ctx.Books.Remove(thisBook);

                //--alle links van dit boek-id in tussentabel naar lijst (boekgenres en boekauteurs) 
                List<BookAuthor> authorLink = ctx.BookAuthors.Where(x => x.BookId == myId).ToList();
                List<BookGenre> genresLink = ctx.BookGenres.Where(x => x.BookId == myId).ToList();

                //--verwijder alle links van dit boek in tussentabellen
                foreach (BookAuthor link in authorLink)
                {
                    ctx.BookAuthors.Remove(link);
                }
                foreach (BookGenre link in genresLink)
                {
                    ctx.BookGenres.Remove(link);
                }

                //-- entity opslaan
                ctx.SaveChanges();
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
            FormAddBook formAddBook = new FormAddBook(false);


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
        private int ReturnPublisherId()
        {
            int id = 0;
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                id = ctx.Publishers.Where(i => i.Naam == lblPubl.Text).Select(f => f.Id).FirstOrDefault();
            }

            return id;
        }
        private void lbxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowSelectionForm();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FormAddBook formChangeBook = new FormAddBook(true);
            formChangeBook.Title = gbxData.Text;
            formChangeBook.PublisherId = ReturnPublisherId();
            formChangeBook.Year = Convert.ToInt32(lblPublYear.Text);
            formChangeBook.Pages = Convert.ToInt32(lblPages.Text);
            formChangeBook.Score = Convert.ToInt32(lblScore.Text);
            formChangeBook.Id = Convert.ToInt32(lblid.Text);

            foreach (string author in lbxAuthors.Items)
            {
                formChangeBook.AuthorsList.Add(author);
            }

            foreach (string genre in lbxGenres.Items)
            {
                formChangeBook.GenreList.Add(genre);
            }

            if (formChangeBook.ShowDialog() == DialogResult.OK)
            {
                UpdateData();
                LoadBookList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("Weet u zeker dat u dit boek wilt verijderen?","",buttons);
            if (result == DialogResult.Yes)
            {
                DeleteBook();
                LoadBookList();
                UpdateData();
            }
        }
    }
}
