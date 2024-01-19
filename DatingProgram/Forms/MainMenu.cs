using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DatingProgram.Data;

namespace DatingProgram.Forms
{
    public partial class MainMenu : Form
    {
        private DataBase dataBase;

        private int CurrentId 
        { 
            get
            {
                if (dataGridView.CurrentRow != null) return int.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString());
                else return -1;

            }
        }
        private string startInfoText;

        private int gender; // 0 - оба пола, 1 - мужчины, 2 - женщины
        private string city;
        private int age1; // минимальный возраст
        private int age2; // максимальный возраст

        public MainMenu()
        {
            age1 = -1;
            age2 = -1;
            city = "";
            gender = 0;
            dataBase = new DataBase();
            InitializeComponent();
            InitializeCheckbox();
            startInfoText = labelWarning.Text;
        }

        // метод настраивает галочки напротив пола
        private void InitializeCheckbox()
        {
            manCheckBox.CheckedChanged -= manCheckBox_CheckedChanged;
            manCheckBox.Checked = true;
            manCheckBox.CheckedChanged += manCheckBox_CheckedChanged;

            womanCheckBox.CheckedChanged -= womanCheckBox_CheckedChanged;
            womanCheckBox.Checked = true;
            womanCheckBox.CheckedChanged += womanCheckBox_CheckedChanged;

            ageFirstNumeric.Validated += AgeFirstNumeric_Validated;
            ageSecondNumeric.Validated += AgeSecondNumeric_Validated;
        }

        // метод срабатывает когда пользователь переключился с ввода возраста на что-то другое
        // (нажал на кнопку, начал вводить другое поле и т.д.)
        private void AgeFirstNumeric_Validated(object sender, EventArgs e)
        {
            if (ageFirstNumeric.Text == "")
            {
                ageFirstNumeric.Text = ageFirstNumeric.Minimum.ToString();
            }
        }

        // аналогично для второго поля с возрастом
        private void AgeSecondNumeric_Validated(object sender, EventArgs e)
        {
            if (ageSecondNumeric.Text == "")
            {
                ageSecondNumeric.Text = (ageFirstNumeric.Value + 1).ToString();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        // метод срабатывает, когда меняется галка напротив фильтрации по возрасту
        private void ageFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Enabled = true - сделать объект не активным (с ним нельзя взаимодействовать)
            // Enabled = false - включить обратно
            ageFirstNumeric.Enabled = ageFilterCheckBox.Checked;
            ageSecondNumeric.Enabled = ageFilterCheckBox.Checked;
            labelAge1.Enabled = ageFilterCheckBox.Checked;
            labelAge2.Enabled = ageFilterCheckBox.Checked;
            if (ageFilterCheckBox.Checked)
                FilterAgeByTwo((int)ageFirstNumeric.Value, (int)ageSecondNumeric.Value);
            else
                FilterAgeByTwo(-1, -1);
        }

        // вызывается, когда меняется значение возраста в первом поле
        private void ageFirstNumeric_ValueChanged(object sender, EventArgs e)
        {
            age1 = (int)ageFirstNumeric.Value;
            AgeFirstValueChanged();
        }

        private void ageSecondNumeric_ValueChanged(object sender, EventArgs e)
        {
            age2 = (int)ageSecondNumeric.Value;
            AgeSecondValueChanged();
            
        }

        // метод вызывается, когда пользователь нажал галку у фильтрации по городу
        private void filterCityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool widgetsEnabled = cityFilterCheckBox.Checked;

            labelCity.Enabled = widgetsEnabled;
            cityTextBox.Enabled = widgetsEnabled;
            filtercCityButton.Enabled = widgetsEnabled;

            string filter = widgetsEnabled ? cityTextBox.Text : "";
            if (filter != "" || city != "") FilterCity(filter);
        }

        private void filterCityButton_Click(object sender, EventArgs e)
        {
            FilterCity(cityTextBox.Text);
        }

        // метод вызывается, когда меняется текст в поле с городом
        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (cityTextBox.Text == "")
            {
                FilterCity("");
            }
        }

        // ниже 2 метода, которые контролирует корректность полей с полом и меняют их при необходимости 
        public void AgeFirstValueChanged()
        {
            if (age1 >= age2)
            {
                ageSecondNumeric.Value = age1 + 1;
                age1 += 1;
            }
                
            UpdateTable();
        }

        public void AgeSecondValueChanged()
        {
            if (age2 <= age1)
            {
                ageFirstNumeric.Value = age2 - 1;
                age2 -= 1;
            }
                
            UpdateTable();
        }

        // метод вызывается, когда нажата кнопка открытия окна с архивом
        private void openArchiveButton_Click(object sender, EventArgs e)
        {
            var archiveWindow = new Archive();
            archiveWindow.ShowDialog(); // открываем окно с архивом
        }

        // метод вызывается при нажатии кнопки удаления записи
        private void deleteElementButton_Click(object sender, EventArgs e)
        {
            if (CurrentId != -1)
            {
                RemoveFromProfilesAndAddToArchive();
                labelWarning.Text = "Запись успешно отправлена в архив!";
                UpdateTable();
            }
            else
            {
                labelWarning.Text = "Не выбрана запись для отправки в архив.";
            }
            
        }

        // метод вызывается при нажатии кнопки редактирования записи
        private void editElementButton_Click(object sender, EventArgs e)
        {
            if (CurrentId != -1)
            {
                labelWarning.Text = startInfoText;
                var editWindow = new EditDialog(CurrentId);

                editWindow.ShowDialog(); // открываем окно редактирования
                // дальнейший код выполняется только после закрытия окна редактирования
                if (editWindow.Success)
                    labelWarning.Text = "Запись успешно отредактирована!";
                UpdateTable();
            }
            else
            {
                labelWarning.Text = "Не выбрана запись для редактирования.";
            }

        }

        // метод вызывается при нажатии кнопки создания новой записи
        private void newElementButton_Click(object sender, EventArgs e)
        {
            var actual = new DataTable();
            var archive = new DataTable();

            dataBase.Open();

            // получаем таблицу архива и таблицу актуальных записей пользователей
            var adapterActual = new SqlDataAdapter("SELECT * FROM MainTable", dataBase.Access);
            var adapterArchive = new SqlDataAdapter("SELECT * FROM Trash", dataBase.Access);

            adapterActual.Fill(actual);
            adapterArchive.Fill(archive);

            dataBase.Close();

            // вычисляем id новой записи (доля этого узнаём сколько всего пользователей: и актуальных и удалённых)
            int id = actual.Rows.Count + archive.Rows.Count + 1;
            var newProfileWindow = new CreationDialog(id); 
            newProfileWindow.ShowDialog(); // открываем окно создания профиля
            // этот код срабатывает после закрытия окна создания записи
            if (newProfileWindow.Success)
            {
                labelWarning.Text = "Запись успешно создана!";
            }
                
            UpdateTable();
        }

        // метод вызывается при нажатии на поле с галочкой напротив мужского пола
        private void manCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!manCheckBox.Checked && !womanCheckBox.Checked)
            {
                manCheckBox.CheckedChanged -= manCheckBox_CheckedChanged;
                manCheckBox.Checked = true;
                manCheckBox.CheckedChanged += manCheckBox_CheckedChanged;
            }
            else
            {
                FilterByGender(CountGender());
            }
        }

        // аналогично для женского
        private void womanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!womanCheckBox.Checked && !manCheckBox.Checked)
            {
                womanCheckBox.CheckedChanged -= womanCheckBox_CheckedChanged;
                womanCheckBox.Checked = true;
                womanCheckBox.CheckedChanged += womanCheckBox_CheckedChanged;
            }
            else
            {
                FilterByGender(CountGender());
            }
        }

        // по состоянию полей с галочками, вычисляет какой пол отбирать из  таблицы
        // 0 - оба, 1 - мужской, 2 - женский
        private int CountGender()
        {
            return manCheckBox.Checked && womanCheckBox.Checked ? 0
                : (manCheckBox.Checked ? 1 : 2);
        }

        // Устанавливает город, по которому мы будем фильтровать
        public void FilterCity(string cityName)
        {
            city = cityName;
            UpdateTable(); // обновляем таблицу
        }

        // Устанавливаем возрастной промежуток, по которому будем фильтровать
        public void FilterAgeByTwo(int firstAge, int secondAge)
        {
            age1 = firstAge;
            age2 = secondAge;
            UpdateTable();
        }

        // Устанавливаем пол, по которому будем фильтровать
        public void FilterByGender(int gender)
        {
            this.gender = gender;
            UpdateTable();
        }

        // Проверка строчки на основе комбинации всех фильтров
        private bool CheckRow(DataRow row)
        {
            return CheckGender(row) && CheckCity(row) && CheckAge(row);

        }

        // проверка строчки на пол
        private bool CheckGender(DataRow row)
        {
            return gender == 0 ||
                row.Field<String>("gender") == (gender == 1 ? "М" : "Ж");
        }

        // проверка строчки на город
        private bool CheckCity(DataRow row)
        {
            return city == "" || row.Field<String>("city") == city;
        }

        // проверка строчки на возраст
        private bool CheckAge(DataRow row)
        {
            int age = Years(row.Field<DateTime>("birth"), DateTime.UtcNow);

            if (age1 != -1 && age2 != -1)
                return age <= age2 && age >= age1;
            else if (age1 != -1)
                return age == age1;
            return true;
        }

        // обновление таблицы
        public void UpdateTable()
        {
            dataGridView.ClearSelection(); // очищаем таблицу
            dataBase.Open();

            DataTable tempTable = new DataTable(); // временная таблица
            DataTable tableToShow = new DataTable(); // таблица, которую мы отобразим
            AddTableHead(tableToShow); // добавляем шапку таблицы

            // переносим во временную таблицу все записи из базы данных
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM MainTable", dataBase.Access);
            adapter.Fill(tempTable);

            dataBase.Close();
            for (int i = 0; i < tempTable.Rows.Count; i++)
            {
                // если строчка подходит под фильтры, добавляем её в таблицу для отображения у пользователя
                if (CheckRow(tempTable.Rows[i]))
                {
                    tableToShow.Rows.Add(ObjectFromRow(tempTable.Rows[i]));
                }
            }

            dataGridView.DataSource = tableToShow; // переносим таблицу в её графическую версию

            // обновляем текст, который выскочит в случае пустой таблицы
            noElementsWarningLabel.Visible = dataGridView.Rows.Count == 0;
        }

        // метод удаляет запись из таблицы с профилями и добавляет в таблицу-архив
        private void RemoveFromProfilesAndAddToArchive()
        {
            int id = CurrentId;
            string removeName = "MainTable";
            string addName = "Trash";
            dataBase.Open();

            // объявляем необходимые команды
            SqlCommand removeCommand = new SqlCommand("delete from " + removeName
                + " where id = " + id + "", dataBase.Access);

            SqlCommand addCommand = WriteCommand(addName, VarObjectFromRow(GetRow(dataBase, removeName, id)));

            // выполняем команды
            addCommand.ExecuteNonQuery();
            removeCommand.ExecuteNonQuery();

            dataBase.Close();
        }

        // метод "собирает" нужную нам команду добавления записи
        private SqlCommand WriteCommand(string nameOfTable, object[] values)
        {
            SqlCommand result = new SqlCommand("insert into " + nameOfTable +
                " (id, date, gender, name, birth, city, about, issues) values (@id, @date, @gender, @name, @birth, @city, @about, @issues)",
                dataBase.Access);

            string[] nameParams = new string[8] { "@id", "@date", "@gender", "@name", "@birth", "@city", "@about", "@issues" };

            for (int i = 0; i < 8; i++)
            {
                result.Parameters.AddWithValue(nameParams[i], values[i]);
            }

            return result;
        }

        // аналогичный метод уже был в окне архива, там есть комментарии
        private object[] ObjectFromRow(DataRow row)
        {
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

        private object[] VarObjectFromRow(DataRow row)
        {
            var id = row.Field<int>("id");
            var date = row.Field<DateTime>("date");
            var gender = row.Field<String>("gender");
            var name = row.Field<String>("name");
            var born = row.Field<DateTime>("birth");
            var city = row.Field<String>("city");
            var aboutMe = row.Field<String>("about");
            var conditions = row.Field<String>("issues");

            object[] res = { id, date, gender, name, born, city, aboutMe, conditions };
            return res;
        }

        // получаем строку из таблицы по её id
        private DataRow GetRow(DataBase dataBase, string nameOfTable, int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + nameOfTable + " where id = " + id + "", dataBase.Access);

            DataTable tempTable = new DataTable();
            adapter.Fill(tempTable);

            return tempTable.Rows[0];
        }

        // метод добавляет шапку таблицы
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

        // метод считает кол-во лет между 2 датами
        private int Years(DateTime a, DateTime b)
        {
            bool addYear = (b.Month > a.Month || b.Month == a.Month) && b.Day >= a.Day;
            return b.Year - a.Year - 1 + (addYear ? 1 : 0);
        }

        private void labelAge1_Click(object sender, EventArgs e)
        {

        }

        private void noElementsWarningLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelWarning_Click(object sender, EventArgs e)
        {

        }

        private void labelCity_Click(object sender, EventArgs e)
        {

        }

        private void labelAge2_Click(object sender, EventArgs e)
        {

        }
    }
}
