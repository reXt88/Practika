﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фгещк
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Добрый день," + Form1.USER.Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.FORMA.Show();
        }
    }
}
