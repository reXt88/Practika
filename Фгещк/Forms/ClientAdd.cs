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

namespace Фгещк.Forms
{
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            Clients cl = new Clients();
            User usr = new User();
            //usr.Login = textBox1.Text + "_" + textBox2.Text + "_" + textBox3.Text;
            Random r = new Random();
            string s = Convert.ToString(r.Next(1000000000));
            while (db.Users.Find("User" + s) != null)
            {
                s = Convert.ToString(r.Next(10000000));
            }

            usr.Login = "User" + s;
            usr.Name = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            usr.Psw = "00000000";
            usr.Role = "Пользователь";
            cl.Фамилия = textBox1.Text;
            cl.Login = usr.Login;
            cl.Имя = textBox2.Text;
            cl.Отчество = textBox3.Text;
            cl.Номер_телефона = maskedTextBox2.Text;
            cl.Возраст = Convert.ToInt32(maskedTextBox1.Text);
            Cllients.CLIENT = cl;
            db.Clients.Add(cl);
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
            MessageBox.Show("Клиент успешно добавлен");
            Cllients frm = new Cllients();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cllients frm = new Cllients();
            frm.Show();
            this.Close();
        }
    }
}
