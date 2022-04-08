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
    public partial class Manager : Form
    {
        static bool appclose = false;
        public Manager()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appclose = true;
            this.Close();
            Entry.FORMA.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Менеджер_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (appclose = false)
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cllients frm = new Cllients();
            frm.Show();
        }
    }
}
