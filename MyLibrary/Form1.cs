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
 * (meerdere) filters toepassen
 * 
 * 
 * 
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

        Dictionary<string, string> sortDic = new Dictionary<string, string>()
        {
            { "Titel A->Z","titleUp" },
            { "Titel Z->A","titleDown" },
            { "Pagina's Laag->Hoog","pagesUp" },
            { "Pagina's Hoog->Laag","pagesDown" },
            { "Publicatie Laag->Hoog","yearUp" },
            { "Publicatie Hoog->Laag","yearDown" } 

        };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            //LoadBookList();
        }
        private void LoadComboBox()
        {
            cbxSort.DataSource = null;
            cbxSort.DataSource = new BindingSource(sortDic, null);
            cbxSort.DisplayMember = "Key";
            cbxSort.ValueMember = "Value";
            cbxSort.SelectedIndex = 0;
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
                List<Book> booklist = new List<Book>();
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

        private void cbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BibliotheekEntities ctx = new BibliotheekEntities())
            {
                List<Book> booklist = new List<Book>();

                switch (cbxSort.SelectedValue.ToString())
                {
                    case "titleDown":
                        booklist = ctx.Books.Select(x => x).OrderByDescending(x => x.Titel).ToList();
                        break;
                    case "pagesUp":
                        booklist = ctx.Books.Select(x => x).OrderBy(x => x.AantalPaginas).ToList();
                        break;
                    case "pagesDown":
                        booklist = ctx.Books.Select(x => x).OrderByDescending(x => x.AantalPaginas).ToList();
                        break;
                    case "yearUp":
                        booklist = ctx.Books.Select(x => x).OrderBy(x => x.publicatie).ToList();
                        break;
                    case "yearDown":
                        booklist = ctx.Books.Select(x => x).OrderByDescending(x => x.publicatie).ToList();
                        break;
                    case "titleUp":
                        booklist = ctx.Books.Select(x => x).OrderBy(x => x.Titel).ToList();
                        break;

                    default:
                        booklist = ctx.Books.Select(x => x).OrderBy(x => x.Id).ToList();
                        break;
                }

                lbxBooks.DisplayMember = "Titel";
                lbxBooks.ValueMember = "Id";
                lbxBooks.DataSource = booklist;


            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FormFilter formFilter = new FormFilter();
            if (formFilter.ShowDialog() == DialogResult.OK)
            {
                using (BibliotheekEntities ctx = new BibliotheekEntities())
                {
                    int filter = -1;

                    //-- Filteren op Auteur
                    if (formFilter.FilterData[0] != -1)
                    {
                        filter = formFilter.FilterData[0];
                        List<Book> books = ctx.Books.Join(
                            ctx.BookAuthors,
                            b => b.Id,
                            ba => ba.BookId,
                            (b,ba) => new {b, ba }).Where(j => j.ba.AuthorId == filter).Select(x => x.b).ToList();

                        lbxBooks.DataSource = null;
                        lbxBooks.DisplayMember = "Titel";
                        lbxBooks.ValueMember = "Id";
                        lbxBooks.DataSource = books;

                    }

                    //-- Filteren op Uitgever
                    if (formFilter.FilterData[1] != -1)
                    {
                        filter = formFilter.FilterData[1];

                        List<Book> books = ctx.Books.Where(b => b.PublisherId == filter).ToList();
                        lbxBooks.DataSource = null;
                        lbxBooks.DisplayMember = "Titel";
                        lbxBooks.ValueMember = "Id";
                        lbxBooks.DataSource = books;

                    }

                    //-- Filteren op Genre
                    if (formFilter.FilterData[2] != -1)
                    {
                        filter = formFilter.FilterData[2];
                        List<Book> books = ctx.Books.Join(
                            ctx.BookGenres,
                            b => b.Id,
                            bg => bg.BookId,
                            (b, bg) => new { b, bg }).Where(j => j.bg.GenreId == filter).Select(x => x.b).ToList();

                        lbxBooks.DataSource = null;
                        lbxBooks.DisplayMember = "Titel";
                        lbxBooks.ValueMember = "Id";
                        lbxBooks.DataSource = books;

                    }

                    //-- Filteren op Publicatiejaar
                    if (formFilter.FilterData[4] != -1)
                    {
                        int filter2 = formFilter.FilterData[3];
                        filter = formFilter.FilterData[4];
                        List<Book> books = new List<Book>();

                        switch (formFilter.PubliText)
                        {
                            case "tussen":
                                books = ctx.Books.Where(b => (b.publicatie <= filter && b.publicatie >= filter2)).ToList();
                                break;
                            case "precies":
                                books = ctx.Books.Where(b => b.publicatie == filter).ToList();
                                break;
                            case "vanaf":
                                books = ctx.Books.Where(b => b.publicatie >= filter).ToList();
                                break;
                            case "tot":
                                books = ctx.Books.Where(b => b.publicatie <= filter).ToList();
                                break;
                            default:
                                MessageBox.Show("something wrong");
                                break;
                        }

                        lbxBooks.DataSource = null;
                        lbxBooks.DisplayMember = "Titel";
                        lbxBooks.ValueMember = "Id";
                        lbxBooks.DataSource = books;
                    }

                    //-- Filteren op Score
                    if (formFilter.FilterData[6] != -1)
                    {
                        int filter2 = formFilter.FilterData[5];
                        filter = formFilter.FilterData[6];
                        List<Book> books = new List<Book>();

                        switch (formFilter.ScoreText)
                        {
                            case "tussen":
                                books = ctx.Books.Where(b => (b.Score <= filter && b.Score >= filter2)).ToList();
                                break;
                            case "precies":
                                books = ctx.Books.Where(b => b.Score == filter).ToList();
                                break;
                            case "vanaf":
                                books = ctx.Books.Where(b => b.Score >= filter).ToList();
                                break;
                            case "tot":
                                books = ctx.Books.Where(b => b.Score <= filter).ToList();
                                break;
                            default:
                                MessageBox.Show("something wrong");
                                break;
                        }

                        lbxBooks.DataSource = null;
                        lbxBooks.DisplayMember = "Titel";
                        lbxBooks.ValueMember = "Id";
                        lbxBooks.DataSource = books;
                    }


                }
            }
        }
    }
}
