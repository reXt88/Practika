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
    public partial class Вход : Form
    {
        public Вход()
        {
            InitializeComponent();
        }
        public static Вход FORMA { get; set; }
        public static User USER { get; set; }
        Model3 db = new Model3();

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
                    Директор frm = new Директор();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.Role == "Менеджер")
                {
                    Менеджер frm = new Менеджер();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.Role == "Администратор")
                {
                    Администратор frm = new Администратор();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Role == "Пользователь"))
                {
                    Пользователь frm = new Пользователь();
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
            Регистрация frm = new Регистрация();
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
    }
}
