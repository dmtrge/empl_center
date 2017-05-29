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
    public partial class aboutcl : Form
    {
        public aboutcl()
        {
            InitializeComponent();
        }

        private void aboutcl_Load(object sender, EventArgs e)
        {
            genform genform = new genform();
            this.id.Text = genform.idcl;
            this.name.Text = genform.name;
            this.surname.Text = genform.surname;
            this.middlename.Text = genform.middlename;
            this.phone.Text = genform.phone;
            this.IDpas.Text = genform.IDpas;
            this.address.Text = genform.address;
            this.education.Text = genform.education;
            this.vacantion.Text = genform.vacantion;
            this.fornotes.Text = genform.fornotes;
            this.data.Text = genform.date;

        }
    }
}
