using DatingProgram.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace DatingProgram.Forms
{
    public partial class EditDialog : Form
    {
        public bool Success => success;

        DateTime dateLocal = DateTime.Now;
        private DataBase dataBase;

        private bool success = false;
        
        private int idFinal;


        public EditDialog(int id)
        {
            this.idFinal = id;
            dataBase = new DataBase();
            InitializeComponent();
            FillFields();
        }
        
        private void FillFields()
        {
            dataBase.Open();
            var Row = GetRow(idFinal);

            String name = Row.Field<String>("name");
            DateTime birthDay = Row.Field<DateTime>("birth");
            String city = Row.Field<String>("city");
            String description = Row.Field<String>("about");
            String contract = Row.Field<String>("issues");
            nameTextBox.Text = name;
            dateTimePicker1.Value = birthDay;
            cityTextBox.Text = city;
            aboutTextBox.Text = description;
            issuesTextBox.Text = contract;

            dataBase.Close();
        }
        
        private bool CheckCity()
        {
            return cityTextBox.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && cityTextBox.Text != "";
        }

        private bool CheckDate()
        {
            return Years(dateTimePicker1.Value, dateLocal) >= 18;
        }

        private bool CheckName()
        {
            return nameTextBox.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && nameTextBox.Text != "";
        }

        private int Years(DateTime a, DateTime b)
        {
            bool addYear = (b.Month > a.Month || b.Month == a.Month) && b.Day >= a.Day;
            return b.Year - a.Year - 1 + (addYear ? 1 : 0);
        }

        // метод достаёт строчку из таблицы по её id
        public DataRow GetRow(int id)
        {
            string tableName = "MainTable";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + tableName +
                " where id = " + id + "", dataBase.Access);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table.Rows[0];
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (CheckCity() && CheckDate() && CheckName())
            {
                dataBase.Open();

                // команда, обновляющая запись
                SqlCommand Command = new SqlCommand("UPDATE [dbo].[MainTable]  SET [date] = date, [gender] = gender, [name] = @name, [birth] = @birth, [city] = @city, [about] = @about, [issues] = @issues WHERE id = " + idFinal + "",
                    dataBase.GetAccess());

                DateTime date = DateTime.Parse(dateTimePicker1.Text);

                Command.Parameters.AddWithValue("name", nameTextBox.Text.ToString());
                Command.Parameters.AddWithValue("birth", $"{date.Month}/{date.Day}/{date.Year}");
                Command.Parameters.AddWithValue("city", cityTextBox.Text.ToString());
                Command.Parameters.AddWithValue("about", aboutTextBox.Text.ToString());
                Command.Parameters.AddWithValue("issues", issuesTextBox.Text.ToString());

                Command.ExecuteNonQuery();
            
                success = true;
                dataBase.Close();
                Close();
            }
            else
            {
                String ErrBox = "Данные введены неверно\n";
                if (!CheckCity() && cityTextBox.Text != "")
                {
                    ErrBox += "> Город должен содержать только буквы русского или латинского алфавита. В случае необходимости - цифры и тире.\n";
                }
                else if (!CheckCity() && cityTextBox.Text == "")
                {
                    ErrBox += "> Поле [город] является обязательным полем\n";
                }
                if (!CheckName() && nameTextBox.Text != "")
                {
                    ErrBox += "> Имя должно содержать только буквы русского или латинского алфавита. В случае необходимости - цифры и тире\n";
                }
                else if (!CheckName() && nameTextBox.Text == "")
                {
                    ErrBox += "> Поле [имя] является обязательным полем\n";
                }
                if (!CheckDate())
                {
                    if (Years(dateTimePicker1.Value, DateTime.UtcNow) < 18)
                        ErrBox += "> Ваш возраст должен быть не менее 18 лет.\n";
                    else
                        ErrBox += "> Ваш возраст превышает верхнюю границу!\n";
                }

                var res = MessageBox.Show(ErrBox, "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }

        }
    }
}
