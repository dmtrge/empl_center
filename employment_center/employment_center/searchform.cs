using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace employment_center
{
    public partial class searchform : Form
    {
        public searchform()
        {
            InitializeComponent();
        }

        private void searchform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.databaseDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.vacantions". При необходимости она может быть перемещена или удалена.
            this.vacantionsTableAdapter.Fill(this.databaseDataSet.vacantions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.vacantions". При необходимости она может быть перемещена или удалена.
            this.vacantionsTableAdapter.Fill(this.databaseDataSet.vacantions);

        }

       

       private void searchbtn_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM vacantions WHERE specialty,about, requirements LIKE '%"+specialtybox.Text+"%';";
            using (var connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\project\employment_center\employment_center\Database.mdf;Integrated Security=True;Connect Timeout=30"))
            using (var command = new SqlCommand(sql, connection))
            using (var adapter = new SqlDataAdapter(command))
            {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView1.DataSource = myTable;
                connection.Close();
            }

          /*  {
                connection.Open();
                var myTable = new DataTable();
                adapter.Fill(myTable);
                dataGridView2.DataSource = myTable;
                connection.Close();
            } */
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
