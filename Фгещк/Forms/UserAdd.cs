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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            Clients cl = new Clients();
            cl.Фамилия = textBox1.Text;
            cl.Имя = textBox2.Text;
            cl.Отчество = textBox3.Text;
            cl.Номер_телефона = maskedTextBox2.Text;
            cl.Возраст = Convert.ToInt32(maskedTextBox1.Text);
            Cllients.CLIENT = cl;
            db.Clients.Add(cl);
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
