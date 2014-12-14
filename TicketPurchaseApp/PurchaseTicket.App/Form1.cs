using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseTicket.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Name = CustomerNameTextBox.Text;
            
            double a = Convert.ToDouble(NoOfTicketTextBox.Text);
            double b = a * 10;
            MessageBox.Show( Name+ ", You Have to Paid  " + b + "  Taka");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = CustomerNameTextBox.Text;
            double unit = Convert.ToDouble(NoOfTicketTextBox.Text);
            double Price = unit * 10;
            MessageBox.Show("Name: " + name + "\n Unit Price: 10 Taka \n Total Price: " +Price);
        }
    }
}
