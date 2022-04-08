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
    public partial class Registration : Form
    {
        static bool appclose = false;
        public Registration()
        {
            InitializeComponent();
        }
        Model3 db = new Model3();
         private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            appclose = true;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Нужно задать все данные");
                return;
            }
            if (textBox2.TextLength < 8)
            {
                MessageBox.Show("пароль не может быть менее 8 символов");
                return;
            }
            if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Значение паролей не совпадают");
                return;
            }
            User usr = db.Users.Find(textBox1.Text);
            if (usr != null)
            {
                MessageBox.Show("Пользователь с таким логином уже есть");
                return;
            }
            usr = new User();
            usr.Login = textBox1.Text;
            usr.Psw = textBox2.Text;
            usr.Role = "Пользователь";
            usr.Name = textBox5.Text;
            db.Users.Add(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show($"Пользователь {usr.Login} зарегистрирован");
            Entry.FORMA.MyShow();
            this.Close();
            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            appclose = true;
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void Регистрация_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!appclose)
                Application.Exit();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
