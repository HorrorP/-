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
using System.Text.RegularExpressions;

namespace CarAccouting
{
    public partial class RentalForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Собственника", "ID собственника");
            dataGridView1.Columns.Add("Дата", "Дата");
            dataGridView1.Columns.Add("ID_Услуги", "Услуга");
            dataGridView1.Columns.Add("ID", "ID");
            this.dataGridView1.Columns["ID"].Visible = false;
        }

        private void ClearFields()
        {
            Addresstb.Text = "";
            //Descriptiontb.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetDateTime(1), record.GetInt32(2), record.GetInt32(3));
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            using (var context = new ManagementTSGContext())
            {
                var financialOperations = context.Финансы
                    .Select(f => new
                    {
                        OwnerId = f.IdСобственника,
                        Date = f.Дата,
                        ServiceId = f.IdУслуги,
                        Id = f.Id
                    })
                    .ToList();

                foreach (var operation in financialOperations)
                {
                    dgw.Rows.Add(operation.OwnerId, operation.Date, operation.ServiceId, operation.Id);
                }
            }
        }


        public RentalForm()
        {
            InitializeComponent();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            
            RefreshDataGrid(dataGridView1);
            
            this.ActiveControl = label1;
            dataGridView1.ClearSelection();
                        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                Addresstb.Text = row.Cells[0].Value.ToString();
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
            }
        }

        private void ClearImg_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            dataGridView1.ClearSelection();
            label5.Text = "";   
        }

        private void AnotherStick_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridView1.ClearSelection();
            label5.Text = "";
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchText = SearchTextBox.Text.ToLower(); // Преобразование текста поиска в нижний регистр для удобства сравнения

            using (var context = new ManagementTSGContext())
            {
                var searchResults = context.Финансы
                    .Where(f => f.IdСобственника.ToString().Contains(searchText) ||
                                f.Дата.ToString().Contains(searchText) ||
                                f.IdУслуги.ToString().Contains(searchText))
                                
                    .Select(f => new
                    {
                        OwnerId = f.IdСобственника,
                        Date = f.Дата,
                        ServiceId = f.IdУслуги,
                        
                    })
                    .ToList();

                foreach (var result in searchResults)
                {
                    dgw.Rows.Add(result.OwnerId, result.Date, result.ServiceId);
                }
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void NewTrainerButton_Click(object sender, EventArgs e)
        {
           
        }

        private void ChangeTrainerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteTrainerButton_Click(object sender, EventArgs e)
        {
            
        }

        private void NewTrainerButton_Click_1(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            string gos = Addresstb.Text;
            string TB1 = textBox1.Text;
            string TB2 = textBox2.Text;
            
            var addQuery = $"insert into Финансы (ID_Собственника, Дата, ID_Услуги) values ('{gos}',{TB1},{TB2})";
            var command = new SqlCommand(addQuery, dbconnection.getConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbconnection.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
            dataGridView1.ClearSelection();

            label5.Text = "";
        }
                   

        private void ChangeTrainerButton_Click_1(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            string gos = Addresstb.Text;
            string TB1 = textBox1.Text;
            string TB2 = textBox2.Text;

            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[3, selectedRowIDX].Value);

           
            var addQuery = $"update Финансы set ID_Собственника = '{gos}', Дата = '{TB1}', ID_Услуги = '{TB2}' where ID = '{aza}'";
            var command = new SqlCommand(addQuery, dbconnection.getConnection());

            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbconnection.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
            dataGridView1.ClearSelection();
                       
             label5.Text = "";
                    
        }

        private void DeleteTrainerButton_Click_1(object sender, EventArgs e)
        {
            dbconnection.openConnection();
            string gos = Addresstb.Text;
            string TB1 = textBox1.Text;
            string TB2 = textBox2.Text;

            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[3, selectedRowIDX].Value);

            if (!string.IsNullOrEmpty(gos))
            {
                var addQuery = $"delete from Финансы where ID = '{aza}'";
                var command = new SqlCommand(addQuery, dbconnection.getConnection());

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbconnection.closeConnection();
                RefreshDataGrid(dataGridView1);
                dataGridView1.ClearSelection();
                ClearFields();   
            }
            else
            {
                MessageBox.Show("Выберите недвижимость для удаления данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
