﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (this.Username.Text == "" || this.Password.Text == "")
            {

            }
        }
    }
}
