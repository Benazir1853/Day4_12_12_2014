﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList();

            for (int i = 1; i <= 10; i++)
            {
                mylist.Add(i);
                CountTextBox.Text = i.ToString();
            }
           


        }
    }
}
