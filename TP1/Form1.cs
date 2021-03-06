using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isValid()
        {
            if (tbUsername.Text != "zuhalrobbani")
            {
                MessageBox.Show("Username salah!", "Error");
                return false;
            }
            else if (tbPassword.Text != "pbo123")
            {
                MessageBox.Show("Password salah!", "Error");
                return false;
            }
            return true;
        }
        private void Login_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                this.Hide();
                MenuUtama Mu = new MenuUtama();
                Mu.Show();
                MessageBox.Show("Welcome!", "Welcome");
            }
        }

       
    }
}
