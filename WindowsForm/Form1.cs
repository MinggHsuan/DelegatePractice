using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Label> pages = CreateLabels();
            foreach (Label page in pages)
            {
                flowLayoutPanel1.Controls.Add(page);
            }
        }

        public List<Label> CreateLabels()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            IEnumerable<Label> pages = numbers.Select(x => new Label() { Text = x.ToString() });

            foreach (Label label in pages)
            {
                label.Click += PageNumber_Click;
            }
            return pages.ToList();
        }

        private void PageNumber_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1");
        }
    }
}
