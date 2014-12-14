using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberStringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbbButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(NumberTextBox.Text);
            NumberListBox.Items.Clear();
            for (int i = 1; i <= number; i++)
            {
                NumberListBox.Items.Add(i);
            }
        }
    }
}
