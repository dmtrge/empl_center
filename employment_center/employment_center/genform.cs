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
    public partial class genform : Form
    {
        public static string id = null;
        public static string field_of_activity = null;
        public static string speciality = null;
        public static string company = null;
        public static string requirements = null;
        public static string salary = null;
        public static string exp = null;
        public static string schedule = null;
        public static string location = null;
        public static string about = null;
        public static string date = null;
        public static string actual = null;

        /// <summary>
        /// Переменные для клиентов
        /// </summary>
        /// 
        public static string idcl = null;
        public static string name = null;
        public static string surname = null;
        public static string middlename = null;
        public static string phone = null;
        public static string IDpas = null;
        public static string address = null;
        public static string education = null;
        public static string vacantion = null;
        public static string fornotes = null;
        public static string datecl = null;
        public genform()
        {
            InitializeComponent();
        }

        private void genform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.databaseDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.vacantions". При необходимости она может быть перемещена или удалена.
            this.vacantionsTableAdapter.Fill(this.databaseDataSet.vacantions);
            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            idcl = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);
            name = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value);
            surname = Convert.ToString(dataGridView2.CurrentRow.Cells[2].Value);
            middlename = Convert.ToString(dataGridView2.CurrentRow.Cells[3].Value);
            phone = Convert.ToString(dataGridView2.CurrentRow.Cells[4].Value);
            IDpas = Convert.ToString(dataGridView2.CurrentRow.Cells[5].Value);
            address = Convert.ToString(dataGridView2.CurrentRow.Cells[6].Value);
            education = Convert.ToString(dataGridView2.CurrentRow.Cells[7].Value);
            vacantion = Convert.ToString(dataGridView2.CurrentRow.Cells[8].Value);
            fornotes = Convert.ToString(dataGridView2.CurrentRow.Cells[9].Value);
            datecl = Convert.ToString(dataGridView2.CurrentRow.Cells[10].Value);
            aboutcl aboutcl = new aboutcl();
            aboutcl.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
            field_of_activity = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            speciality = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            company = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            requirements = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
            salary = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
            exp = Convert.ToString(dataGridView1.CurrentRow.Cells[6].Value);
            schedule = Convert.ToString(dataGridView1.CurrentRow.Cells[7].Value);
            location = Convert.ToString(dataGridView1.CurrentRow.Cells[8].Value);
            about = Convert.ToString(dataGridView1.CurrentRow.Cells[9].Value);
            actual = Convert.ToString(dataGridView1.CurrentRow.Cells[10].Value);
            date = Convert.ToString(dataGridView1.CurrentRow.Cells[11].Value);
            aboutbox aboutbox = new aboutbox();
            aboutbox.Show();
        }

        private void панельАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preadmin preadmin = new preadmin();
            preadmin.Show();

        }

        private void открытьДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Настоятельно рекомендуется использовать браузер google chrome для дальнейшей работы!");
            System.Diagnostics.Process.Start("https://google.com");
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 AboutBox1 = new AboutBox1();
            AboutBox1.Show();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vacantionsTableAdapter.FillBy(this.databaseDataSet.vacantions);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
