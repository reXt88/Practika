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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DefaulUser frm = new DefaulUser();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prodDataSet1.ProductNew". При необходимости она может быть перемещена или удалена.
            this.productNewTableAdapter.Fill(this.prodDataSet1.ProductNew);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pr
            // TODO: данная строка кода позволяет загрузить данные в таблицу "clientsData.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.clientsData.Clients);
            button3.Text = Entry.USER.Login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entry.KORZ = Entry.KORZ + listBox1.Text + "\n";
            MessageBox.Show("Товар добавлен в корзину");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Учетная запись")
            {
                Учетная_запись frm = new Учетная_запись();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Каталог товаров")
            {
                Products frm = new Products();
                frm.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Корзина")
            {
                Korzina frm = new Korzina();
                frm.Show();
                this.Hide();
            }
        }
    }
}
