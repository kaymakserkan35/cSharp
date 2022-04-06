using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApartmanOtomasyonDeneme
{
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }

        MySqlHelper can=new MySqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int daireno = Convert.ToInt32(comboBox1.Text);
            int para =(int)numericUpDown1.Value;
            DateTime yeni = dateTimePicker1.Value;

            MySqlParameter p1 =new MySqlParameter("Daireno",daireno);
            MySqlParameter p2 =new MySqlParameter("Para",para);
            MySqlParameter p3 =new MySqlParameter("Tarih",yeni);

            can.ExecuteProc("aidat",p1,p2,p3);


        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
            DataTable canan = can.GetTable("select * from AidatOdemesi");

            foreach (DataRow herhangi in canan.Rows)
            {
                listBox1.Items.Add(herhangi["DaireNo"]).ToString();
                listBox2.Items.Add(herhangi["Para"]).ToString();
                listBox3.Items.Add(herhangi["Tarih"]).ToString();
            }
        }
    }
}
