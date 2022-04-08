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
    public partial class Пользователь : Form
    {
        public Пользователь()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Вход.FORMA.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "Добрый день, " + Вход.USER.Name;
        }
    }
}
