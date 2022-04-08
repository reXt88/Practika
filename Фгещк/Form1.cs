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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 FORMA { get; set; }
        public static User USER { get; set; }
        Model3 db = new Model3();

        private void button1_Click(object sender, EventArgs e)
        {
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
                    Form2 frm = new Form2();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.Role == "Менеджер")
                {
                    Form3 frm = new Form3();
                    frm.Show();
                    this.Hide();
                }
                else if (usr.Role == "Администратор")
                {
                    Form5 frm = new Form5();
                    frm.Show();
                    this.Hide();
                }
                else if ((usr.Role == "Пользователь"))
                {
                    Form6 frm = new Form6();
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
            Form4 frm = new Form4();
            FORMA = this;
            this.Hide();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
