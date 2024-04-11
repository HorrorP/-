using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;

namespace CarAccouting
{
    
    public partial class MainForm : Form
    {
        private readonly CheckUser _user;
        private readonly ManagementTSGContext _context;
        DBConnection dbconnection = new DBConnection();
        public MainForm(CheckUser user)
        {
            _user = user;
                        _context = new ManagementTSGContext();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            label1.Text = $"{_user.Login}: {_user.Status}";
            label6.Text = $"{_user.Employee_ID}";
            label6.Visible = false;
            this.ActiveControl = label6;
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Собственник", "Собственник");
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("Услуга", "Услуга");
            dataGridView1.Columns.Add("Сумма", "Сумма");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetDateTime(1),  record.GetString(2), record.GetDecimal(3));
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelChangeUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuthenticateForm authenticateForm = new AuthenticateForm();
            authenticateForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RentalForm cf = new RentalForm();
            cf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerForm df = new OwnerForm();
            df.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from OwnerFinancialService_data";
            SqlCommand command = new SqlCommand(queryString, dbconnection.getConnection());

            dbconnection.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            dbconnection.closeConnection();

        }
    }
}

