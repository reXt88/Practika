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
using Фгещк.Forms;

namespace Фгещк.Forms
{
    public partial class ClientDel : Form
    {
        public ClientDel()
        {
            InitializeComponent();
        }
        private void UserDel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientsData.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.clientsData.Clients);
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                Model3 db = new Model3();
                Clients cl = db.Clients.Find(Convert.ToInt32(comboBox1.Text));
                Cllients.CLIENT = cl;
                label3.Text = "ФИО:";
                label1.Text = Cllients.CLIENT.Фамилия + " " + Cllients.CLIENT.Имя + " " + Cllients.CLIENT.Отчество;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model3 db = new Model3();
            Clients cl = db.Clients.Find(Convert.ToInt32(comboBox1.Text));
            cl = db.Clients.Remove(cl);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Клиент успешно удален");
            this.Close();
            Cllients frm = new Cllients();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Cllients frm = new Cllients();
            frm.Show();
        }
    }
}
