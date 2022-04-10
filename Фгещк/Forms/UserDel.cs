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
    public partial class UserDel : Form
    {
        public UserDel()
        {
            InitializeComponent();
        }

        private void UserDel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sampleDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sampleDataSet.Users);
            comboBox1.Text = "";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Model3 db = new Model3();
                User usr = db.Users.Find(comboBox1.Text);
                Entry.USER = usr;
                label2.Text = "Имя";
                label3.Text = usr.Name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            User usr = db.Users.Find(comboBox1.Text);
            usr = db.Users.Remove(usr);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Сотрудник уволен");
            this.Close();
            Users frm = new Users();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Users frm = new Users();
            frm.Show();
        }
    }
}
