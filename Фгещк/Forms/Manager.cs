using System;
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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        //public void MyShow()
        //{
        //    comboBox1.Text = Entry.USER.Login;
        //    this.Show();
        //}
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
            //Cllients frm = new Cllients();
            //frm.Show();
            //this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Учетная_запись frm = new Учетная_запись();
            //frm.Show();
            //frm.owner = this;
            //this.Hide();
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
    }
}
