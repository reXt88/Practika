using System;
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
    public partial class Director : Form
    {
        public Director()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button2.Text = Entry.USER.Login;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Учетная запись")
            {
                Учетная_запись frm = new Учетная_запись();
                frm.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Клиенты")
            {
                Cllients frm = new Cllients();
                frm.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "Пользователи")
            {
                Users frm = new Users();
                frm.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void Директор_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Учетная_запись frm = new Учетная_запись();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
