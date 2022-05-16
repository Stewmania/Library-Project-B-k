
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buk_Main_Interface));
            this.Control_Bar = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Search_Bar = new System.Windows.Forms.TextBox();
            this.Control_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control_Bar
            // 
            this.Control_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Control_Bar.Controls.Add(this.Exit_Btn);
            this.Control_Bar.Controls.Add(this.Search_Bar);
            this.Control_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Control_Bar.Location = new System.Drawing.Point(0, 0);
            this.Control_Bar.Name = "Control_Bar";
            this.Control_Bar.Size = new System.Drawing.Size(953, 36);
            this.Control_Bar.TabIndex = 0;
            this.Control_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Control_Bar_MouseDown);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Exit_Btn.Image")));
            this.Exit_Btn.Location = new System.Drawing.Point(12, 3);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(32, 30);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.UseVisualStyleBackColor = false;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            this.Exit_Btn.MouseLeave += new System.EventHandler(this.Exit_Btn_Leave);
            this.Exit_Btn.MouseHover += new System.EventHandler(this.Exit_Btn_Hover);
            // 
            // Search_Bar
            // 
            this.Search_Bar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Search_Bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Search_Bar.Location = new System.Drawing.Point(750, 9);
            this.Search_Bar.Margin = new System.Windows.Forms.Padding(0);
            this.Search_Bar.Multiline = true;
            this.Search_Bar.Name = "Search_Bar";
            this.Search_Bar.Size = new System.Drawing.Size(150, 18);
            this.Search_Bar.TabIndex = 0;
            this.Search_Bar.Text = "   Search";
            // 
            // Buk_Main_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 593);
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
        private System.Windows.Forms.Button Exit_Btn;
    }
}

