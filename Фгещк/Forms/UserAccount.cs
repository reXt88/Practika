using System;
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
    public partial class Учетная_запись : Form
    {
        public void MyShow()
        {
            this.Show();
            label3.Text = Entry.USER.Psw;
        }
        public Form owner;
        public static Учетная_запись FORMA { get; set; }
        public Учетная_запись()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Учетная_запись_Load(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            User usr = Entry.USER;
            FORMA = this;
            label1.Text = usr.Name;
            label2.Text = usr.Role;
            label3.Text = usr.Psw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Смена_пароля frm = new Смена_пароля();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            owner.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    } 
}
