
namespace Admin_Member_Login
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FacebookLoginBTN = new System.Windows.Forms.Button();
            this.GoogleLoginBTN = new System.Windows.Forms.Button();
            this.UserNameTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.RememberMeChckBox = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.LoginBtn);
            this.panel1.Controls.Add(this.RememberMeChckBox);
            this.panel1.Controls.Add(this.PasswordLBL);
            this.panel1.Controls.Add(this.UserNameLBL);
            this.panel1.Controls.Add(this.PasswordTxtBox);
            this.panel1.Controls.Add(this.UserNameTxtBox);
            this.panel1.Controls.Add(this.GoogleLoginBTN);
            this.panel1.Controls.Add(this.FacebookLoginBTN);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ForgotPasswordLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 523);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ForgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(85, 421);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(175, 33);
            this.ForgotPasswordLabel.TabIndex = 0;
            this.ForgotPasswordLabel.Text = "Forgot Password ?";
            this.ForgotPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ForgotPasswordLabel.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Admin_Member_Login.Properties.Resources.Google;
            this.pictureBox2.Location = new System.Drawing.Point(89, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // FacebookLoginBTN
            // 
            this.FacebookLoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FacebookLoginBTN.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacebookLoginBTN.Location = new System.Drawing.Point(147, 40);
            this.FacebookLoginBTN.Name = "FacebookLoginBTN";
            this.FacebookLoginBTN.Size = new System.Drawing.Size(251, 50);
            this.FacebookLoginBTN.TabIndex = 4;
            this.FacebookLoginBTN.Text = "Facebook Login";
            this.FacebookLoginBTN.UseVisualStyleBackColor = true;
            // 
            // GoogleLoginBTN
            // 
            this.GoogleLoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoogleLoginBTN.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleLoginBTN.Location = new System.Drawing.Point(147, 110);
            this.GoogleLoginBTN.Name = "GoogleLoginBTN";
            this.GoogleLoginBTN.Size = new System.Drawing.Size(251, 50);
            this.GoogleLoginBTN.TabIndex = 5;
            this.GoogleLoginBTN.Text = "Google Login";
            this.GoogleLoginBTN.UseVisualStyleBackColor = true;
            // 
            // UserNameTxtBox
            // 
            this.UserNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserNameTxtBox.Location = new System.Drawing.Point(191, 212);
            this.UserNameTxtBox.Name = "UserNameTxtBox";
            this.UserNameTxtBox.Size = new System.Drawing.Size(207, 20);
            this.UserNameTxtBox.TabIndex = 6;
            this.UserNameTxtBox.Text = "UserName";
            this.UserNameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(192, 258);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(207, 20);
            this.PasswordTxtBox.TabIndex = 7;
            this.PasswordTxtBox.Text = "Password";
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLBL.Location = new System.Drawing.Point(86, 212);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(88, 17);
            this.UserNameLBL.TabIndex = 8;
            this.UserNameLBL.Text = "UserName";
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.Location = new System.Drawing.Point(88, 258);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(86, 17);
            this.PasswordLBL.TabIndex = 10;
            this.PasswordLBL.Text = "Password";
            // 
            // RememberMeChckBox
            // 
            this.RememberMeChckBox.AutoSize = true;
            this.RememberMeChckBox.Font = new System.Drawing.Font("Ravie", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMeChckBox.Location = new System.Drawing.Point(91, 311);
            this.RememberMeChckBox.Name = "RememberMeChckBox";
            this.RememberMeChckBox.Size = new System.Drawing.Size(142, 21);
            this.RememberMeChckBox.TabIndex = 11;
            this.RememberMeChckBox.Text = "Remember Me";
            this.RememberMeChckBox.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(89, 348);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(310, 50);
            this.LoginBtn.TabIndex = 12;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
        
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 523);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FacebookLoginBTN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GoogleLoginBTN;
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox UserNameTxtBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.CheckBox RememberMeChckBox;
    }
}

