namespace ApartmanOtomasyonDeneme
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
            this.gelirler = new System.Windows.Forms.Button();
            this.giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gelirler
            // 
            this.gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gelirler.Location = new System.Drawing.Point(117, 48);
            this.gelirler.Name = "gelirler";
            this.gelirler.Size = new System.Drawing.Size(148, 258);
            this.gelirler.TabIndex = 0;
            this.gelirler.Text = "Gelirler";
            this.gelirler.UseVisualStyleBackColor = true;
            this.gelirler.Click += new System.EventHandler(this.gelirler_Click);
            // 
            // giderler
            // 
            this.giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.giderler.Location = new System.Drawing.Point(397, 48);
            this.giderler.Name = "giderler";
            this.giderler.Size = new System.Drawing.Size(148, 258);
            this.giderler.TabIndex = 1;
            this.giderler.Text = "Giderler";
            this.giderler.UseVisualStyleBackColor = true;
            this.giderler.Click += new System.EventHandler(this.giderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giderler);
            this.Controls.Add(this.gelirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gelirler;
        private System.Windows.Forms.Button giderler;
    }
}

