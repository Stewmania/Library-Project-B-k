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

namespace Buk
{
    public partial class Buk_Main_Interface : Form
    {
        public Buk_Main_Interface()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

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
    }
}
