using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridVİewCellTypes
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ExamineDataGridViewObject()
        {
            var examine = this.dataGridViewExamine;
            var textobject = dataGridViewExamine.Columns[0];
            var buttonobject = dataGridViewExamine.Columns[1];
            var checkobject = dataGridViewExamine.Columns[2];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExamineDataGridViewObject();
        }

        private void Doldur_Click(object sender, EventArgs e)
        {
            List<Entity> entities = new List<Entity>();
            for (int i = 1; i < 5; i++)
            {
                entities.Add(new Entity()
                {
                    Id = i,
                    Name = i.ToString(),
                });
            }
          
            dataGridView1.DataSource = entities;
            DataGridViewButtonColumn button = new DataGridViewButtonColumn()
            {
                Name = "button",
                HeaderText = "Button",
                Text = "Button",
                UseColumnTextForButtonValue = true //dont forget this line
            };
            this.dataGridView1.Columns.Add(button);

            DataGridViewCheckBoxColumn checkbox = new DataGridViewCheckBoxColumn()
            {
                Name = "checkbox",
                HeaderText = "checkbox"
            };
            this.dataGridView1.Columns.Add(checkbox);

            DataGridViewCheckBoxColumn text = new DataGridViewCheckBoxColumn()
            {
                Name = "text",
                HeaderText = "text"
            };
            this.dataGridView1.Columns.Add(text);
        }


    }
}
