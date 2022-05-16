
namespace Buk
{
    partial class Buk_Main_Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.Search_Bar = new System.Windows.Forms.TextBox();
            this.Control_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Control_Bar.Controls.Add(this.Search_Bar);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(960, 36);
            this.Control_Bar.TabIndex = 0;
            this.Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_Bar_MouseDown);
            // 
            // Search_Bar
            // 
            this.Search_Bar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Search_Bar.Location = new System.Drawing.Point(789, 9);
            this.Search_Bar.Margin = new System.Windows.Forms.Padding(0);
            this.Search_Bar.Multiline = true;
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.Size = new System.Drawing.Size(150, 20);
            this.Search_Bar.TabIndex = 0;
            this.Search_Bar.Text = "   Search";
            // 
            // Buk_Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Control_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buk_Main_Interface";
            this.Text = "Buk";
            this.Control_Bar.ResumeLayout(false);
            this.Control_Bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Control_Bar;
        private System.Windows.Forms.TextBox Search_Bar;
    }
}

