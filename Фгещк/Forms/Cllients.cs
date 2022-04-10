using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фгещк.Forms;
using Фгещк.qwe;

namespace Фгещк
{
    public partial class Cllients : Form
    {
        public Cllients()
        {
            InitializeComponent();
        }
        public static Clients CLIENT { get; set; }
        private void Клиенты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientsData.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter1.Fill(this.clientsData.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UserAdd frm = new UserAdd();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager frm = new Manager();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDel frm = new UserDel();
            frm.Show();
            this.Close();
        }
    }
}
