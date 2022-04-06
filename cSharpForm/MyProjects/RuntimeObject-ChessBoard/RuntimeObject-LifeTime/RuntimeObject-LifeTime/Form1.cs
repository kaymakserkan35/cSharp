using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeObject_LifeTime
{
    public partial class Form1 : Form
    {
        private int kacakaclıkbirkare { get; set; } = 5;
        private int TotalButtonNumber { get; set; }
        private List<Button> buttons { get; set; }

        public Form1()
        {
            //  this.Controls.Add(button2);
            InitializeComponent();
            buttons = new List<Button>();
            CreateButton(kacakaclıkbirkare * kacakaclıkbirkare);
        }

        public void CreateButton(int numberOfButton = 1)
        {
            for (int i = 1; i <= numberOfButton; i++)
            {
                Button button = new System.Windows.Forms.Button();
                buttons.Add(button);
                button.Name = "myButton" + i.ToString();
                SetButtonSize(button);
                SetButtonLocation(button, i - 1);
                button.TabIndex = 0;
                button.Text = "my created button";
                button.Click += Button_Click;
                this.Controls.Add(button);
            }
        }

        private void SetButtonSize(Button button)
        {
            button.Width = this.Width / kacakaclıkbirkare - 2;
            button.Height = this.Height / kacakaclıkbirkare - 5;

        }
        private void SetButtonLocation(Button button, int TotalButtonNumber)
        {

            int x = TotalButtonNumber % kacakaclıkbirkare;
            button.Location = new System.Drawing.Point(0 + button.Width * x, (int)(0 + Math.Floor((double)(TotalButtonNumber / kacakaclıkbirkare)) * button.Height));

        }
        private void ResizeButtons(List<Button> buttons)
        {
            foreach (var button in buttons)
            {
                SetButtonSize(button);
            }
        }
        private void ReLocateButtons(List<Button> buttons)
        {
            int sayac = 0;
            foreach (var button in buttons)
            {

                SetButtonLocation(button, sayac);
                sayac += 1;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            EventArgs eventArgs = e;
            MessageBox.Show(btn.Name + "clicked!");
        }

        private void FormResized(object sender, EventArgs e)
        {
            ResizeButtons(buttons);
            ReLocateButtons(buttons);
        }


    }
}
