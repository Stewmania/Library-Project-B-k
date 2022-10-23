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

namespace Buk
{
    public partial class Buk_Main_Interface : Form
    {

        public static string currentBarcode = null;

        public Buk_Main_Interface()
        {
            InitializeComponent();  
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
            string q = "";
            while (!process.HasExited)
            {
                q += process.StandardOutput.ReadToEnd();




            }
            testOutput.Text = q;
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
                }
                f2.Show();
                String[] coverURLS = {"https://m.media-amazon.com/images/I/512xFZRDM3L._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51L4QD5L2vL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51mQnL9z7RL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51QwExcEvXL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/518Jx+cKHiL._SY346_.jpg"};
                ConfirmationForm confirmForm = new ConfirmationForm(coverURLS, false);
                confirmForm.Show();
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
                String[] coverURLS = {"https://m.media-amazon.com/images/I/512xFZRDM3L._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51L4QD5L2vL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51mQnL9z7RL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/51QwExcEvXL._SY346_.jpg",
                                    "https://m.media-amazon.com/images/I/518Jx+cKHiL._SY346_.jpg"};
                ConfirmationForm confirmForm = new ConfirmationForm(coverURLS, true);
                confirmForm.Show();
            }
        }

        private void Buk_Main_Interface_Load(object sender, EventArgs e)
        {

        }

        private void testOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
