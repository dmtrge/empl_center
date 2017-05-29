using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employment_center
{
    public partial class preadmin : Form
    {
        public preadmin()
        {
            InitializeComponent();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            if (passwdbox.Text == "passwd")
            {
                admin admin = new admin();
                admin.Show();
            }
            else
            {
                MessageBox.Show("Пароль неправильный!");
            }
        }
    }
}
