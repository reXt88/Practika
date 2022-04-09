using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фгещк.Users;

namespace Фгещк
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }
        public static bool isChanged { get; set; } = false;
        public static Entry FORMA { get; set; }
        public static User USER { get; set; }
        public void MyShow()
        {
            this.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль");
                return;
            }
            User usr = db.Users.Find(textBox1.Text);
            if ((usr != null) && (usr.Psw == textBox2.Text))
            {
                USER = usr;
                FORMA = this;
                if (usr.Role == "Директор")
                {
                    Director frm = new Director();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.Role == "Менеджер")
                {
                    Manager frm = new Manager();
                    frm.Show();
                    this.Hide();
                }
                else if (textBox1.Text == "admin" && textBox2.Text == "admin")
                {
                    Administrator frm = new Administrator();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Role == "Пользователь"))
                {
                    DefaulUser frm = new DefaulUser();
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Пользователя с таким логином и паролем нет");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration frm = new Registration();
            FORMA = this;
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Вход_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Вход_Load(object sender, EventArgs e)
        {

        }
    }
}
