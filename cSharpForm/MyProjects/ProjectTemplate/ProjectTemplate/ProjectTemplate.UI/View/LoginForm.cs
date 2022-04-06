using ProjectTemplate.SERVİCE;
using ProjectTemplate.UI.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTemplate.UI.View
{
    public partial class LoginForm : Form
    {
        ServiceController serviceController;

        public LoginForm(ServiceController serviceController)
        {
            this.serviceController = serviceController;
            InitializeComponent();
            ReStoreTable();
        }
        private void GetEntitiesBTN_Click(object sender, EventArgs e)
        {
            ReStoreTable();
        }

        private void ReStoreTable()
        {
            this.dataGridView1.Columns.Clear();
            dataGridView1.DataSource = serviceController.GetEntities();

            DataGridViewButtonColumn DeleteButton = new DataGridViewButtonColumn()
            {
                Name = "DeleteButton",
                Text = "DeleteButton",
                UseColumnTextForButtonValue = true
            };
            this.dataGridView1.Columns.Add(DeleteButton);

            DataGridViewButtonColumn UpdateButton = new DataGridViewButtonColumn()
            {
                Name = "UpdateButton",
                Text = "UpdateButton",
                UseColumnTextForButtonValue = true
            };
            this.dataGridView1.Columns.Add(UpdateButton);
        }
    }
}
