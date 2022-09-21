namespace Buk
{
    partial class BarcodeScanner
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Camera: ";
            // 
            // cboCamera
            // 
            this.cboCamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(83, 16);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(469, 24);
            this.cboCamera.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 49);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(540, 313);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.AutoSize = true;
            this.barcodeLabel.Location = new System.Drawing.Point(9, 368);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(65, 17);
            this.barcodeLabel.TabIndex = 3;
            this.barcodeLabel.Text = "Barcode:";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(73, 365);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(398, 22);
            this.txtBarcode.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(477, 365);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(15, 396);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(539, 23);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // BarcodeScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 431);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.barcodeLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.label1);
            this.Name = "BarcodeScanner";
            this.Text = "BarcodeScanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BarcodeScanner_FormClosing);
            this.Load += new System.EventHandler(this.BarcodeScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button submitButton;
    }
}