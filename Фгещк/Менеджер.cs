using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Фгещк
{
    public partial class Менеджер : Form
    {
        public Менеджер()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "Добрый день, " + Вход.USER.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход.FORMA.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Менеджер_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
