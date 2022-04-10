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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        public static Manager FORMA { get; set; }
        private void Form3_Load(object sender, EventArgs e)
        {
            FORMA = this;
            comboBox1.Text = Entry.USER.Login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void Менеджер_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
