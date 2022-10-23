using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

/*
 * https://m.media-amazon.com/images/I/512xFZRDM3L._SY346_.jpg
    https://m.media-amazon.com/images/I/51L4QD5L2vL._SY346_.jpg
    https://m.media-amazon.com/images/I/51mQnL9z7RL._SY346_.jpg
    https://m.media-amazon.com/images/I/51QwExcEvXL._SY346_.jpg
    https://m.media-amazon.com/images/I/518Jx+cKHiL._SY346_.jpg
 */

namespace Buk
{
    public partial class ConfirmationForm : Form
    {

        private String[] bookCoverURLS;
        private bool usedSearchBar;

        public ConfirmationForm(String[] bookCoverURLS, bool usedSearchBar)
        {
            InitializeComponent();
            this.bookCoverURLS = bookCoverURLS;
            this.usedSearchBar = usedSearchBar;
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {

            if (usedSearchBar)
            {
                foreach (String url in this.bookCoverURLS)
                {
                    CheckBox box = new CheckBox();
                    box.Width = 150;
                    box.Height = 200;
                    box.Image = resizeImage(getImageFromURL(url));
                    box.CheckAlign = ContentAlignment.BottomCenter;
                    layoutPanel.Controls.Add(box);
                }
            }
            else
            {
                foreach (String url in this.bookCoverURLS)
                {
                    RadioButton radioButton = new RadioButton();
                    radioButton.Width = 150;
                    radioButton.Height = 200;
                    radioButton.Image = resizeImage(getImageFromURL(url));
                    radioButton.CheckAlign = ContentAlignment.BottomCenter;
                    layoutPanel.Controls.Add(radioButton);
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

        private void confirmationLabel_Click(object sender, EventArgs e)
        {

        }

        private void continueButton_Click(object sender, EventArgs e)
        {

        }
    }
}
