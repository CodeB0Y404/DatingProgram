using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DatingProgram.Data;
using System;

namespace DatingProgram.Forms
{
    public partial class Archive : Form
    {
        // Свойство (Можно обращаться как к полю, но самом деле это почти что метод)
        // Возвращает id записи, которую сейчас выделил пользователь в таблице
        // Возвращает -1, если ничего не выделено
        private int CurrentId
        {
            get
            {
                if (dataGridView.CurrentRow != null) // проверяем, выделена ли запись вообще
                    return int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()); 
                return -1;
            }
        }

        // база данных
        private DataBase dataBase;

        // конструктор
        public Archive()
        {
            dataBase = new DataBase();
            InitializeComponent();
        }

        // метод запускается при открытии окна
        private void ArchiveWindow_Load(object sender, System.EventArgs e)
        {
            TableUpdate();
        }

        // метод запускается при нажатии кнопки выхода
        private void exitButton_Click(object sender, System.EventArgs e)
        {
            Close(); // форма закрывается
        }

        // метод обновляет таблицу (визуально)
        public void TableUpdate()
        {
            dataBase.Open(); 
            // определяем адаптер, которым в будущем заполним таблицу
            // он достаёт из таблицы Trash (Архив) все записи
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Trash", dataBase.Access);
            dataBase.Close();

            // далее создаём некую пустую абстрактную таблицы
            DataTable tableToShow = new DataTable();
            // заполняем её адаптором
            FillTable(tableToShow, adapter);

            // используем эту таблицу как сурс, чтобы заполнить уже графическую таблицу в окошке
            dataGridView.DataSource = tableToShow;

            // если таблица получилось пустая (нет записей в архиве), вывешиваем сообщение, что записей нет
            emptyTableLabel.Visible = dataGridView.Rows.Count == 0;
        }

        // метод заполняет таблицу с помощью адаптера и добавляет шапку
        private void FillTable(DataTable table, SqlDataAdapter adapter)
        {
            // создаем временную таблицу для записей
            DataTable tempTable = new DataTable();
            adapter.Fill(tempTable);

            // заполняем шапку таблицы
            AddTableHead(table);

            // переносим записи из временной таблицы в переданную таблицу
            foreach (DataRow row in tempTable.Rows)
                table.Rows.Add(ObjectFromRow(row));
        }

        // метод добавляет таблице шапку
        public static void AddTableHead(DataTable table)
        {
            table.Columns.Add("Регистрационный номер");
            table.Columns.Add("Дата регистрации");
            table.Columns.Add("Пол");
            table.Columns.Add("Имя");
            table.Columns.Add("Возраст");
            table.Columns.Add("Город");
            table.Columns.Add("О себе");
            table.Columns.Add("Требования к партнеру");
        }

        // переводит строку в массив типа object
        // object - это базовый тип данных для всех типов данных в C#
        // поэтому в массив типа object можно засунуть  всё, что угодно
        private object[] ObjectFromRow(DataRow row)
        {
            // получаем значения полей
            // в треугольных скобках тип данных в который надо перевести поле из таблицы
            // в круглых имя поля в таблице
            var id = row.Field<int>("id");
            var date = row.Field<DateTime>("date");
            var gender = row.Field<String>("gender");
            var name = row.Field<String>("name");
            var born = Years(row.Field<DateTime>("birth"), DateTime.UtcNow);
            var city = row.Field<String>("city");
            var aboutMe = row.Field<String>("about");
            var conditions = row.Field<String>("issues");

            object[] res = { id, date, gender, name, born, city, aboutMe, conditions };
            return res;
        }

        

        private int Years(DateTime a, DateTime b)
        {
            bool addYear = (b.Month > a.Month || b.Month == a.Month) && b.Day >= a.Day;
            return b.Year - a.Year - 1 + (addYear ? 1 : 0);
        }
    }
}
