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
    public partial class Директор : Form
    {
        public Директор()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Добрый день, " + Вход.USER.Name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход.FORMA.Show();
        }

        private void Директор_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
