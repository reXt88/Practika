﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фгещк.Forms;

namespace Фгещк
{
    public partial class DefaulUser : Form
    {
        public DefaulUser()
        {
            InitializeComponent();
        }
        public static DefaulUser FORMA { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            FORMA = this;
            button2.Text = Entry.USER.Login;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Учетная_запись frm = new Учетная_запись();
            frm.Show();
            this.Hide();
        }

        private void Пользователь_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Учетная запись")
            {
                Учетная_запись frm = new Учетная_запись();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Каталог товаров")
            {
                Products frm = new Products();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Корзина")
            {
                Korzina frm = new Korzina();
                frm.Show();
                this.Hide();
            }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
