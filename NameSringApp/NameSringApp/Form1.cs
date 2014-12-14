using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] name = new string[10];
        int count= 0;
        private void saveButton_Click(object sender, EventArgs e)
        {
           if (count<10)
            {
                name[count] =nameTextBox.Text;
                count++;
                countTextBox.Text = Convert.ToString(count);
                nameTextBox.Text = String.Empty;

            }
           else
           {
               MessageBox.Show("You cannot store anymore names");
           }
            if (count==10)

         
            
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            nameListBox.Items.Clear();
            for(int j=0;j<count;j++)
            {
                nameListBox.Items.Add(name[j]);
            }
        }
    }
}
