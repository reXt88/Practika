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

namespace Фгещк.Forms
{
    public partial class Add_User : Form
    {
        public Add_User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Нужно задать все данные");
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
            usr.Psw = "00000000";
            usr.Name = textBox3.Text;
            usr.Role = textBox4.Text;
        }
    }
}
