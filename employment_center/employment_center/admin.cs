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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void addvacantionbtn_Click(object sender, EventArgs e)
        {
            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\project\employment_center\employment_center\Database.mdf;Integrated Security=True;Connect Timeout=30";

            using (var myConnection = new SqlConnection(сonnectionString))

            {

                myConnection.Open();

                var sqlCommand = new SqlCommand("INSERT INTO vacantions (field_of_activity, speciality, company, requirements,salary, exp, schedule, location,date, actual ) VALUES(@field_of_activity, @speciality, @company, @requirements, @salary, @exp, @graph, @schedule,@about, @date, @actual)", myConnection);


                sqlCommand.Parameters.Add(new SqlParameter("@field_of_activity", field_of_activitybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@specialty",specialtybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@company", companybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@requirements", requirementsbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@salary", salarybox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@exp", expbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@schedule", schedulebox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@location",locationbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@about", aboutbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@actual", actualbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@date", createcal.Value));
                MessageBox.Show("Запись создана успешнно");
                this.Close();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }

        private void addclient_Click(object sender, EventArgs e)
        {
            var сonnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dmtrge\OneDrive\project\employment_center\employment_center\Database.mdf;Integrated Security=True;Connect Timeout=30";

            using (var myConnection = new SqlConnection(сonnectionString))

            {

                myConnection.Open();

                var sqlCommand = new SqlCommand("INSERT INTO clients (name, surname, middlename, phone, IDpas, address, education, vacantion, fornotes, date) VALUES(@name, @surname, @middlename, @phone, @IDpas, @address, @education, @vacantion, @fornotes, @date)", myConnection);


                sqlCommand.Parameters.Add(new SqlParameter("@name",namebox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@surname", surnamebox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@middlename", middlenamebox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@phone", phone.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@IDpas", IDpas.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@address", addressbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@education", educationbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@vacantion", vacantionbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@fornotes",fornotesbox.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@date",createclientdata.Value));
                MessageBox.Show("Запись создана успешнно");
                this.Close();
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                finally
                {
                    myConnection.Close();
                }

            }
        }
    }
}
