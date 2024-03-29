﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фгещк.qwe;

namespace Фгещк
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }
        Model3 db = new Model3();

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = db.Users.Find(comboBox1.Text);
            usr.Role = comboBox2.Text;
            Entry.USER = usr;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Роль изменена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                User usr = db.Users.Find(comboBox1.Text);
                if (comboBox1.Text != "")
                {
                    usr = db.Users.Remove(usr);
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Пользователь удален");
                }
                else
                    MessageBox.Show("Выберите пользователя");
            }
        }

        private void Администратор_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sampleDataSet.Users);
            comboBox1.Text = "";
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox2.DroppedDown = true;
        }
    }
}
