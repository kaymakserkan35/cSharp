using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonDeneme
{
    public partial class Giderler : Form
    {
        public Giderler()
        {
            InitializeComponent();
        }
        MySqlHelper can =new MySqlHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            int para = (int)numericUpDown1.Value;
            DateTime tarih = dateTimePicker1.Value;
            string giderler = "";
            foreach (Control item in groupBox1.Controls)
            {
                if (item is CheckBox && ((CheckBox)item).Checked)
                {
                    giderler += ","+item.Text;
                }
            }

            giderler = giderler.Remove(0, 1);

            MySqlParameter p1=new MySqlParameter("Gider",giderler);
            MySqlParameter p2 =new MySqlParameter("Para",para);
            MySqlParameter p3 =new MySqlParameter("Tarih",tarih);

            can.ExecuteProc("giderlerim",p1,p2,p3);
        }

        private void Giderler_Load(object sender, EventArgs e)
        {
            DataTable canan = can.GetTable("select * from Gider_Tablosu");

            foreach (DataRow item in canan.Rows)
            {
                listBox1.Items.Add(item[3]).ToString();
                listBox2.Items.Add(item[1]).ToString();
                listBox3.Items.Add(item[2]).ToString();
            }
        }
    }
}
