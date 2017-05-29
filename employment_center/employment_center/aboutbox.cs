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
    public partial class aboutbox : Form
    {
        public aboutbox()
        {
            InitializeComponent();
        }

        private void aboutbox_Load(object sender, EventArgs e)
        {
            genform genform = new genform();
            this.id.Text = genform.id;
            this.field_of_activity.Text = genform.field_of_activity;
            this.specialty.Text = genform.speciality;
            this.company.Text = genform.company;
            this.requirements.Text = genform.requirements;
            this.salary.Text = genform.salary;
            this.exp.Text = genform.exp;
            this.schedule.Text = genform.schedule;
            this.location.Text = genform.location;
            this.about.Text = genform.about;
            this.actual.Text = genform.actual;
            this.date.Text = genform.date;

        }
    }
}
