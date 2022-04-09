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
    public partial class DefaulUser : Form
    {
        public DefaulUser()
        {
            InitializeComponent();
        }
        public static DefaulUser FORMA { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Entry.FORMA.MyShow();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            FORMA = this;
            button2.Text = "Учетная запись " + Entry.USER.Login;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Учетная_запись frm = new Учетная_запись();
            frm.Show();
            frm.owner = this;
            this.Hide();
        }

        private void Пользователь_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
