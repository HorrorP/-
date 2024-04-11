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
    public partial class EmployeeForm : Form
    {
        DBConnection dbconnection = new DBConnection();
        int selectedRow;

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Имя", "Имя");
            dataGridView1.Columns.Add("Фамилия", "Фамилия");
            dataGridView1.Columns.Add("Квартира", "Квартира");
            dataGridView1.Columns.Add("Телефон", "Телефон");
            dataGridView1.Columns.Add("ID", "ID");
            this.dataGridView1.Columns["ID"].Visible = false;
            
        }

        private void ClearFields()
        {
            Logintextbox.Text = "";
            Passwordtextbox.Text = "";
            Efiotextbox.Text = "";
            
            Ephonetextbox.Text = "";
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetInt32(4));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            using (var context = new ManagementTSGContext())
            {
                var owners = context.Собственники
                    .Select(o => new
                    {
                        FirstName = o.Имя,
                        LastName = o.Фамилия,
                        Apartment = o.Квартира,
                        Phone = o.Телефон,
                        Id = o.Id
                    })
                    .ToList();

                foreach (var owner in owners)
                {
                    dgw.Rows.Add(owner.FirstName, owner.LastName, owner.Apartment, owner.Phone, owner.Id);
                }
            }
        }


        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
            dataGridView1.ClearSelection();
            CreateColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                Efiotextbox.Text = row.Cells[1].Value.ToString();
                Ephonetextbox.Text = row.Cells[3].Value.ToString();
                Logintextbox.Text = row.Cells[0].Value.ToString();
                Passwordtextbox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void ClearImg_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            dataGridView1.ClearSelection();
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
                int searchInt;
                bool isNumeric = int.TryParse(searchText, out searchInt);

                var searchResults = context.Собственники
                    .Where(o => o.Имя.Contains(searchText) ||
                                o.Фамилия.Contains(searchText) ||
                                (isNumeric && o.Квартира == searchInt) ||
                                o.Телефон.Contains(searchText))
                    .Select(o => new
                    {
                        FirstName = o.Имя,
                        LastName = o.Фамилия,
                        Apartment = o.Квартира,
                        Phone = o.Телефон,
                    })
                    .ToList();

                foreach (var result in searchResults)
                {
                    dgw.Rows.Add(result.FirstName, result.LastName, result.Apartment, result.Phone);
                }
            }
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        // Add emp
        private void AddEmpp()
        {
            dbconnection.openConnection();
            var login = Logintextbox.Text;
            var password = Passwordtextbox.Text;
            var fio = Efiotextbox.Text;
            var phone = Ephonetextbox.Text;
            

            string pattern = @"^[А-ЯЁ][а-яё]";
            string pattern2 = @"\+\d{1}\(\d{3}\)\d{3}-\d{4}";


            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
            // Проверка пользователя в БД на Телефон
            DataTable table1 = new DataTable();
            string querystring1 = $"select * from [Employees] where [Employee_phone] = '{phone}'";
            SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
            sqlDataAdapter1.SelectCommand = sqlCommand1;
            sqlDataAdapter1.Fill(table1);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(fio)  && !string.IsNullOrEmpty(phone))//&& !string.IsNullOrEmpty(jobt)
            {
                if ((Regex.IsMatch(fio, pattern, RegexOptions.IgnoreCase)) /*|| (Regex.IsMatch(fio, pattern1, RegexOptions.IgnoreCase))*/)
                {
                    if (Regex.IsMatch(phone, pattern2, RegexOptions.IgnoreCase) && Ephonetextbox.TextLength == 15)
                    {
                        if (table1.Rows.Count == 0)
                        {
                            
                                var addQuery = $"insert into Собственники (Имя, Фамилия, Квартира, Телефон) values ('{login}','{fio}','{password}','{phone}')";
                                var command = new SqlCommand(addQuery, dbconnection.getConnection());
                                
                                
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    dbconnection.closeConnection();
                                    RefreshDataGrid(dataGridView1);
                                    ClearFields();
                                    SearchTextBox.Text = "";
                                    
                                    dataGridView1.ClearSelection();
                                
                           
                        }
                        else
                        {
                            MessageBox.Show("В базе уже есть сотрудник с таким телефоном!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dbconnection.closeConnection();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Телефон введен некорректно, либо же допущены лишние пробелы. Формат телефона:+7(9xx)xxx-xx-xx.",
                                                       "Проверьте правильность ввода",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Введенное ФИО некорректно. Оно должно состоять из двух(при отсутствии отчества) или трех слов, начинающихся с заглавной буквы",
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

        private void NewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmpp();
        }

        // up emp
        private void UpdateEmp()
        {

            var login = Logintextbox.Text;
            var password = Passwordtextbox.Text;
            
            var fio = Efiotextbox.Text;
            
            var phone = Ephonetextbox.Text;


            string pattern = @"^[А-ЯЁ][а-яё]";
            string pattern2 = @"\+\d{1}\(\d{3}\)\d{3}-\d{4}";


            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[4, selectedRowIDX].Value);



            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(fio)  && !string.IsNullOrEmpty(phone))//&& !string.IsNullOrEmpty(jobt)
            {
                dbconnection.openConnection();

                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter();
                // Проверка пользователя в БД на Телефон
                DataTable table1 = new DataTable();
                string querystring1 = $"select * from [Собственники] where [ID] = '{aza}'";
                SqlCommand sqlCommand1 = new SqlCommand(querystring1, dbconnection.getConnection());
                sqlDataAdapter1.SelectCommand = sqlCommand1;
                sqlDataAdapter1.Fill(table1);

                if ((Regex.IsMatch(fio, pattern, RegexOptions.IgnoreCase)) )
                {
                    if (Regex.IsMatch(phone, pattern2, RegexOptions.IgnoreCase) && Ephonetextbox.TextLength == 15)
                    {
                        if (table1.Rows.Count == 1)
                        {
                           
                                    var addQuery = $"update Собственники set Имя = '{login}', Фамилия = '{fio}', Квартира = '{password}', Телефон = '{phone}' where [ID] = '{aza}'";//, Employee_job_title = '{jobt}'
                                    var command = new SqlCommand(addQuery, dbconnection.getConnection());

                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Запись успешно обновлена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    dbconnection.closeConnection();
                                    RefreshDataGrid(dataGridView1);
                                    ClearFields();
                                    SearchTextBox.Text = "";
                                    //checkBox1.Checked = false;
                                    dataGridView1.ClearSelection();
                                
                          
                        }
                        else
                        {
                            MessageBox.Show("Ошибка", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Телефон введен некорректно, либо же допущены лишние пробелы. Формат телефона:+7(9xx)xxx-xxxx.",
                                                       "Проверьте правильность ввода",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введенное фамилия некорректна.",
                                            "Проверьте правильность ввода.",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите собственника для обновления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ChangeEmployeeButton_Click(object sender, EventArgs e)
        {
            UpdateEmp();
        }

        
        private void DeleteEmp()
        {
            var login = Logintextbox.Text;
            var password = Passwordtextbox.Text;
            var fio = Efiotextbox.Text;
            
            var phone = Ephonetextbox.Text;

            var selectedRowIDX = dataGridView1.CurrentCell.RowIndex;
            var aza = Convert.ToInt32(dataGridView1[4, selectedRowIDX].Value);

            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(phone))//&& !string.IsNullOrEmpty(jobt)
            {
                dbconnection.openConnection();

                var addQuery = $"delete from Собственники where ID = '{aza}'";
                var command = new SqlCommand(addQuery, dbconnection.getConnection());

                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dbconnection.closeConnection();
                RefreshDataGrid(dataGridView1);
                SearchTextBox.Text = "";
                ClearFields();
                dataGridView1.ClearSelection();
            }
            else
            {
                MessageBox.Show("Выберите собственника для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            DeleteEmp();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
