using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using IronPython.Hosting;
using IronPython.Runtime;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using Microsoft.VisualBasic.FileIO;

namespace Buk
{
    public partial class Buk_Main_Interface : Form
    {

        public static string currentBarcode = null;
        private List<Dictionary<string, string>> booksToAddToDatabase;

        public Buk_Main_Interface()
        {
            InitializeComponent();
            this.booksToAddToDatabase = new List<Dictionary<string, string>>();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void getBook(string barcode)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = @"..\..\FetchBuks\amazon\fetchBuk.exe";
            process.StartInfo.Arguments = barcode;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.Start();
            process.WaitForExit();
        }

        private void Control_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Exit_Btn_Hover(object sender, EventArgs e)
        {

        }

        private void Exit_Btn_Leave(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leftSidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bukLibraryLabel_Click(object sender, EventArgs e)
        {

        }

        private void libraryButton_Click(object sender, EventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void wishListButton_Click(object sender, EventArgs e)
        {

        }

        private void barcodeScanner_Click(object sender, EventArgs e)
        {
            using (BarcodeScanner f2 = new BarcodeScanner())
            {
                var result = f2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string barcode = f2.currentBarcodeResult;
                    getBook(barcode);
                    using (ConfirmationForm confirmForm = new ConfirmationForm(parseCSV(), false))
                    {
                        var result2 = confirmForm.ShowDialog();
                        if (result2 == DialogResult.OK)
                        {
                            this.booksToAddToDatabase = confirmForm.booksToAddToUserLibrary;
                        }

                        // Can be removed at any time - was just for testing
                        foreach(var book in this.booksToAddToDatabase)
                        {
                            Debug.WriteLine(book["Title"]);
                        }
                    }

                }
                f2.Show();   
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBar.Text))
            {
                // TODO: figure out how to make textbox red to let user know its a required field
            }
            else
            {
                getBook(searchBar.Text);
                searchBar.Text = "";
                using (ConfirmationForm confirmForm = new ConfirmationForm(parseCSV(), true))
                {
                    var result2 = confirmForm.ShowDialog();
                    if (result2 == DialogResult.OK)
                    {
                        this.booksToAddToDatabase = confirmForm.booksToAddToUserLibrary;
                    }

                    // Can be removed at any time - was just for testing
                    foreach(var book in this.booksToAddToDatabase)
                    {
                        Debug.WriteLine(book["Title"]);
                    }
                }
            }
        }

        private List<Dictionary<string, string>> parseCSV()
        {
            var file = new StreamReader(@"..\..\bin\Debug\returnedBooks.csv");
            string text = System.IO.File.ReadAllText(@"..\..\bin\Debug\returnedBooks.csv");
            List<Dictionary<string, string>> books = new List<Dictionary<string, string>>();

            var values = text.Split(new string[] { "\r\n\r" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < values.Length; i++)
            {
                TextFieldParser parser = new TextFieldParser(new StringReader(values[i].Trim()));
                parser.HasFieldsEnclosedInQuotes = true;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    Dictionary<string, string> bookInformation = new Dictionary<string, string>();
                    bookInformation.Add("Title", fields[0]);
                    bookInformation.Add("Description", fields[1]);
                    bookInformation.Add("Cover", fields[2]);
                    bookInformation.Add("Published Date", fields[3]);
                    bookInformation.Add("Rating", fields[4]);
                    bookInformation.Add("Author(s)", fields[5]);
                    books.Add(bookInformation);
                }

            }
            return books;
        }

        private void Buk_Main_Interface_Load(object sender, EventArgs e)
        {

        }

        private void testOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
