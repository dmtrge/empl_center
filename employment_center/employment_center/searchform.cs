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

        
    }
}
