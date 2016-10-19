namespace Pixels_and_Window
{
    partial class Form1
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
            this.lblPixelslabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPixelslabel
            // 
            this.lblPixelslabel.AutoSize = true;
            this.lblPixelslabel.Location = new System.Drawing.Point(13, 13);
            this.lblPixelslabel.Name = "lblPixelslabel";
            this.lblPixelslabel.Size = new System.Drawing.Size(104, 13);
            this.lblPixelslabel.TabIndex = 0;
            this.lblPixelslabel.Text = "Pixels in Windows = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPixelslabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPixelslabel;
    }
}

