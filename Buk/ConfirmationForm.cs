using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace Buk
{
    public partial class ConfirmationForm : Form
    {

        private List<Dictionary<string, string>> books;
        private String[] bookTitles;
        private String[] bookCoverURLS;
        private bool usedSearchBar;
        public List<Dictionary<string, string>> booksToAddToUserLibrary { get; set; }

    public ConfirmationForm(List<Dictionary<string, string>> books, bool usedSearchBar)
        {
            InitializeComponent();
            this.books = books;
            this.usedSearchBar = usedSearchBar;
            setBookTitleAndCoverURLS();
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (usedSearchBar)
            {

                foreach (String url in this.bookCoverURLS)
                {
                    CheckBox box = new CheckBox();
                    box.Width = 150;
                    box.Height = 200;
                    box.Name = count.ToString();
                    if (url == null || url.Equals(""))
                    {
                        box.Text = this.bookTitles[count];
                        box.CheckAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        box.Image = resizeImage(getImageFromURL(url));
                        box.CheckAlign = ContentAlignment.BottomCenter;
                    }
                    layoutPanel.Controls.Add(box);
                    count++;
                }
                
            }
            else
            {
                foreach (String url in this.bookCoverURLS)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Width = 150;
                    radioButton.Height = 200;
                    radioButton.Name = count.ToString();
                    if (url == null || url.Equals(""))
                    {
                        radioButton.Text = this.bookTitles[count];
                        radioButton.CheckAlign = ContentAlignment.MiddleLeft;
                    }
                    else
                    {
                        radioButton.Image = resizeImage(getImageFromURL(url));
                        radioButton.CheckAlign = ContentAlignment.BottomCenter;
                    }
                    layoutPanel.Controls.Add(radioButton);
                    count++;
                }
            }
        }

        private Image getImageFromURL(string url)
        {
            WebRequest req = WebRequest.Create(url);
            WebResponse res = req.GetResponse();
            Stream imgStream = res.GetResponseStream();
            Image image = Image.FromStream(imgStream);
            imgStream.Close();

            return image;
        }

        private Bitmap resizeImage(Image image)
        {
            Bitmap resizedImage = new Bitmap(150, 200);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
                graphics.DrawImage(image, new Rectangle(0, 0, 150, 200), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            return resizedImage;
        }

        private void setBookTitleAndCoverURLS() 
        {
            int numberOfBooks = this.books.Count;
            this.bookTitles = new string[numberOfBooks];
            this.bookCoverURLS = new string[numberOfBooks];
            
            int count = 0;
            foreach(var book in this.books) 
            {
                this.bookTitles[count] = book["Title"];
                this.bookCoverURLS[count] = book["Cover"];
                count++;
            }
        }

        private void confirmationLabel_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            List<int> selectedBooks = new List<int>();
            List<Dictionary<string, string>> tempList = new List<Dictionary<string, string>>();

            if (this.usedSearchBar)
                selectedBooks = checkWhichCheckBoxesAreChecked();
            else
                selectedBooks = checkWhichRadioBtnIsChecked();

            if (selectedBooks.Count == 0)
            {
                // do nothing - user has not made a selection
            }
            else 
            {
                foreach(int bookNumber in selectedBooks)
                {
                    Dictionary<string, string> tempDict = this.books[bookNumber];
                    tempList.Add(tempDict);
                }

                using (var connection = new SQLiteConnection("Data Source = BukDB.db"))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = @"
                    
                   INSERT INTO Library (Title, Author, Description, Cover, PublishD, Rating) 
                    VALUES ('test title', 'test Author', 'test desc', 'test cover', 'test publish', 'test rating' )
                ";

                    int commandResult = command.ExecuteNonQuery();
                    
                }



                this.booksToAddToUserLibrary = tempList;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private List<int> checkWhichCheckBoxesAreChecked()
        {
            List<int> selectedBooks = new List<int>();
            foreach (Control control in layoutPanel.Controls)
            {
                if (control is CheckBox)
                {
                    if (((CheckBox)control).Checked)
                    {
                        selectedBooks.Add(Convert.ToInt32(control.Name));
                    }
                }
            }
            return selectedBooks;
        }

        private List<int> checkWhichRadioBtnIsChecked()
        {
            List<int> selectedBooks = new List<int>();
            foreach (Control control in layoutPanel.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked)
                    {
                        selectedBooks.Add(Convert.ToInt32(control.Name));
                    }
                }
            }
            return selectedBooks;
        }
    }
}
