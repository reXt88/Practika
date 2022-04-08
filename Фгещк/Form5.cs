using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Фгещк.Users;

namespace Фгещк
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Model3 db = new Model3();

        private void button1_Click(object sender, EventArgs e)
        {
            User usr = db.Users.Find(textBox1.Text);
            usr.Role = textBox3.Text;
            
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show($"Роль изменена");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.FORMA.Show();
        }
    }
}
