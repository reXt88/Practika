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
    public partial class Смена_пароля : Form
    {
        Model3 db = new Model3();
        public Смена_пароля()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            User usr = db.Users.Find(Entry.USER.Login);
            usr.Psw = textBox1.Text;
            Entry.USER = usr;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Пароль успешно изменен");
            this.Close();
            Entry change = new Entry();
            Учетная_запись.FORMA.Invalidate();
            Учетная_запись.FORMA.MyShow();
        }

        private void Смена_пароля_Load(object sender, EventArgs e)
        {
            
        }
    }
}
