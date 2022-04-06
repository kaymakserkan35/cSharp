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
    public partial class MyForm1 : Form
    {
        public MyForm1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyForm2 myform2 = new MyForm2();
            myform2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(exitCode: 0);
            //anasayfa ise bütünm programı geğilse o formu kapatır
            // Application.Run(new MyForm1()); Program.cs teki MyForm1 anasayfayı gösterir
            this.Close();
        }
    }
}
