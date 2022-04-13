using System;
using System.Linq;
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
            button3.Text = Entry.USER.Login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + listBox1.Text + "\n";
            Model3 db = new Model3();
            ProductNew pr = db.ProductNew.ToList().Find(x=>x.Название==listBox1.Text);
            Entry.SUM = Entry.SUM + Convert.ToInt32(pr.Цена);
            Entry.KORZ = Entry.KORZ + listBox1.Text + "\n";
            string [] masKORZ = Entry.KORZ.Split('\n');
            Entry.masKORZ = masKORZ;
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
