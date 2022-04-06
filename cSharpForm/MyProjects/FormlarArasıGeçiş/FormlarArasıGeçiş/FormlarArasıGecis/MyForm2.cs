using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıGecis
{
    public partial class MyForm2 : Form
    {
        public MyForm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyForm1 myform1 = new MyForm1();
            myform1.Show();
            myform1.ShowDialog();

            this.Hide();
            this.Close();

        }

        private void MyForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
