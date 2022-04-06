using DIContainer_Form.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIContainer_Form
{
    public partial class Form1 : Form
    {
        public ATemplate Template { get; set; }

        public Form1(ATemplate _template)
        {

            this.Template = _template;
            InitializeComponent();
            this.Label0.Text = Template.TemplateMethod();
            this.label1.Text = Template.GetConnectionString();

        }


    }
}
