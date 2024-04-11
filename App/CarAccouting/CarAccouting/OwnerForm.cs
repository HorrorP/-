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
    public partial class OwnerForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Стоимость", "Стоимость");
            dataGridView1.Columns.Add("ID", "ID");
            this.dataGridView1.Columns["ID"].Visible = false;
        }


        private void ClearFields()
        {
            fiotb.Text = "";
            Passporttb.Text = "";
            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetDecimal(1), record.GetInt32(2));
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            using (var context = new ManagementTSGContext())
            {
                var services = context.Услуги
                    .Select(s => new
                    {
                        Name = s.Название,
                        Cost = s.Стоимость,
                        Id = s.Id
                    })
                    .ToList();

                foreach (var service in services)
                {
                    dgw.Rows.Add(service.Name, service.Cost, service.Id);
                }
            }
        }




        public OwnerForm()
        {
            InitializeComponent();
        }

        private void DriverForm_Load(object sender, EventArgs e)
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
                fiotb.Text = row.Cells[0].Value.ToString();
                Passporttb.Text = row.Cells[1].Value.ToString();
                
            }
        }

        private void ClearImg_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
        }

        private void AnotherStick_Click(object sender, EventArgs e)
        {
            ClearFields();
            dataGridView1.ClearSelection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchText = SearchTextBox.Text.ToLower(); // Преобразование текста поиска в нижний регистр для удобства сравнения

            using (var context = new ManagementTSGContext())
            {
                var searchResults = context.Услуги
                    .Where(s => s.Название.Contains(searchText) ||
                                s.Стоимость.ToString().Contains(searchText)
                                )
                    .Select(s => new
                    {
                        Name = s.Название,
                        Cost = s.Стоимость
                    })
                    .ToList();

                foreach (var result in searchResults)
                {
                    dgw.Rows.Add(result.Name, result.Cost);
                }
            }
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void AddDriver()
        {
            dbconnection.openConnection();
            string fio = fiotb.Text;
            var statusString = Passporttb.Text;

            string pattern = @"^[А-ЯЁ][а-яё]*$";
            

            try
            {
                if (!string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(statusString))//&& !string.IsNullOrEmpty(phone)
                {
                    if (Regex.IsMatch(fio, pattern, RegexOptions.IgnoreCase))
                    {
                        decimal status = decimal.Parse(statusString);
                        var addQuery = $"insert into Услуги (Название, Стоимость) values ('{fio}','{status}')";//,'{phone}'
                        var command = new SqlCommand(addQuery, dbconnection.getConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbconnection.closeConnection();
                        RefreshDataGrid(dataGridView1);
                        ClearFields();
                        dataGridView1.ClearSelection();
                                                                                 
                        
                    }
                    else
                    {
                        MessageBox.Show("Введенное название некорректно.",
                                                "Проверьте правильность ввода.",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля для ввода!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dbconnection.closeConnection();
                }
            }
            catch(SqlException)
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dbconnection.closeConnection();

            }
        }

        private void NewTrainerButton_Click(object sender, EventArgs e)
        {
            AddDriver();
        }

        private void UpdateDriver()
        {
            dbconnection.openConnection();
            string fio = fiotb.Text;
            string statusString = Passporttb.Text;
            decimal status;
            //ool containsOnlyDigits = status.All(char.IsDigit);

            string pattern = @"^[А-ЯЁ][а-яё]*$";
            //string pattern1 = @"^[А-ЯЁ][а-яё]*(?:\s[А-ЯЁ][а-яё]*){1}?\r?$";
            //string pattern2 = @"\+[?\\7\s]+([\(\s\-]?\d+[\)\s\-]?[\d\s\-]+)?";

            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[2, selectedRowIDX].Value);
            
            
            if (!string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(statusString))
            {
                    if (Regex.IsMatch(fio, pattern, RegexOptions.IgnoreCase))
                    {
                        if (decimal.TryParse(statusString, out status))
                        {

                        //decimal status = decimal.Parse(statusString);
                        var addQuery = $"update Услуги set Название = '{fio}', Стоимость = '{status}' where ID = '{aza}'";
                        var command = new SqlCommand(addQuery, dbconnection.getConnection());

                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dbconnection.closeConnection();
                        RefreshDataGrid(dataGridView1);
                        ClearFields();
                        dataGridView1.ClearSelection();
                        }
                        else
                        {
                        MessageBox.Show("Некорректное значение стоимости. Пожалуйста, введите допустимое числовое значение.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Введенное название некорректно.",
                                                "Проверьте правильность ввода.",
                                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            else
            {
                    MessageBox.Show("Выберите водителя для обновления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeTrainerButton_Click(object sender, EventArgs e)
        {
            UpdateDriver();
        }

        private void DeleteDriver()
        {
            dbconnection.openConnection();
            string fio = fiotb.Text;
            string status = Passporttb.Text;
            

            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[2, selectedRowIDX].Value);

            if (!string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(status) )
            {
                var addQuery = $"delete from Услуги where ID = '{aza}'";
                var command = new SqlCommand(addQuery, dbconnection.getConnection());

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbconnection.closeConnection();
                RefreshDataGrid(dataGridView1);
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Выберите Собственника для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTrainerButton_Click(object sender, EventArgs e)
        {
            DeleteDriver();
            ClearFields();
        }
    }
}
