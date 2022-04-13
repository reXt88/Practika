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
    public partial class Korzina : Form
    {
        public Korzina()
        {
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
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

        private void Korzina_Load(object sender, EventArgs e)
        {
            comboBox1.Text = Entry.USER.Login;
            for (int i = 0; i < Entry.masKORZ.Length; i++)
            {
                listBox1.Items.Add(Entry.masKORZ[i].ToString());
            }
            textBox1.Text = Entry.SUM.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Text);
            Entry.KORZ = listBox1.Text;
            Model3 db = new Model3();
            ProductNew pr = db.ProductNew.ToList().Find(x => x.Название == listBox1.Text);
            Entry.SUM = Entry.SUM - Convert.ToInt32(pr.Цена);
        }
    }
}
