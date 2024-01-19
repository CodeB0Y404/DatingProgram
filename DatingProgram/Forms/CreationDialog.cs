using DatingProgram.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;


namespace DatingProgram.Forms
{
    public partial class CreationDialog : Form
    {
        // свойство, по которому главное окно отслеживает, создан новый профиль в результате работы с окном ли нет
        public bool Success => success;

        private DataBase dataBase;
        DateTime dateLocal = DateTime.Now; // текущая дата
        private bool checkedMan; // true если галочка на мужском поле, false - на женском
        int idFinal; // id новой записи, которую мы создадим
        private bool success = false; 

        public CreationDialog(int id)
        {
            this.idFinal = id;
            dataBase = new DataBase();
            InitializeComponent();
            InitializeCheckBox();
        }

        // метод настраивает поля с галочками
        private void InitializeCheckBox()
        {
            manCheckBox.Checked = true;
            womanCheckBox.Checked = false;
            checkedMan = true;
        }

        // метод проверки поля для ввода с городом на корректность
        private bool CheckCity()
        {
            return cityTextBox.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && cityTextBox.Text != "";
        }

        // метод проверки поля для ввода с именем на корректность
        private bool CheckName()
        {
            return nameTextBox.Text.All(c => Char.IsLetterOrDigit(c) || c == '-' || c == ' ') && nameTextBox.Text != "";
        }

        // метод проверки поля для ввода с датой на корректность
        private bool CheckDate()
        {
            return Years(dateTimePicker1.Value, dateLocal) >= 18;
        }

        // метод считает кол-во лет между 2 датами
        private int Years(DateTime a, DateTime b)
        {
            bool addYear = (b.Month > a.Month || b.Month == a.Month) && b.Day >= a.Day;
            return b.Year - a.Year - 1 + (addYear ? 1 : 0);
        }

        // метод срабатывает, когда убрали или поставили галочку на мужском поле
        private void manCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Checked возвращает true, если галка стоит
            if (manCheckBox.Checked)
                switchWomanCheckBoxState(CheckState.Unchecked); //  отключаем галку на женском поле
            else
                switchManCheckBoxState(CheckState.Checked); // ставим галку на мужской пол обратно

            checkedMan = true;
        }

        // метод срабатывает, когда убрали или поставили галочку на женском поле
        private void womanCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // метод устроен аналогично верхнему, там комментарии
            if (womanCheckBox.Checked)
                switchManCheckBoxState(CheckState.Unchecked);
            else
                switchWomanCheckBoxState(CheckState.Checked);

            checkedMan = false;
        }

        private void switchManCheckBoxState(CheckState newState)
        {
            // верхняя и нижняя строчка отключают и включают обратно срабатывание метода чуть выше
            // чтобы мы не попали в рекурсию с бесконечным изменением статуса галочки
            manCheckBox.CheckedChanged -= manCheckBox_CheckedChanged;
            manCheckBox.CheckState = newState;
            manCheckBox.CheckedChanged += manCheckBox_CheckedChanged;
        }

        private void switchWomanCheckBoxState(CheckState newState)
        {
            // метод устроен аналогично верхнему, там комментарии
            womanCheckBox.CheckedChanged -= womanCheckBox_CheckedChanged;
            womanCheckBox.CheckState = newState;
            womanCheckBox.CheckedChanged += womanCheckBox_CheckedChanged;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // если все поля корректны, выполняем первый блок, иначе второй
            if (CheckCity() && CheckName() && CheckDate())
            {
                String gender;
                if (checkedMan)
                    gender = "М";
                else
                    gender = "Ж";
                dataBase.Open();

                // создаём команду добавления новой записи в таблицу в базе
                SqlCommand command = new SqlCommand(
                     $"INSERT INTO MainTable(id, date, gender, name, birth, city, about, issues) values(@id, @date, @gender, @name, @birth, @city, @about, @issues)",
                     dataBase.GetAccess());

                DateTime date = DateTime.Parse(dateTimePicker1.Text);

                // устанавливаем значения параметров из команды
                command.Parameters.AddWithValue("id", idFinal);
                command.Parameters.AddWithValue("date", dateLocal);
                command.Parameters.AddWithValue("gender", gender);
                command.Parameters.AddWithValue("name", nameTextBox.Text.ToString());
                command.Parameters.AddWithValue("birth", $"{date.Month}/{date.Day}/{date.Year}");
                command.Parameters.AddWithValue("city", cityTextBox.Text.ToString());
                command.Parameters.AddWithValue("about", aboutTextBox.Text.ToString());
                command.Parameters.AddWithValue("issues", issuesTextBox.Text.ToString());

                // выполняем команду
                command.ExecuteNonQuery().ToString();
                // открываем окошечко с сообщением
                MessageBox.Show("Профиль создан!", "Действие выполнено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // меняем статус успеха создания окна для главного окна
                success = true;
                dataBase.Close();
                // закрываем окно
                Close();
            }
            else
            {
                // собираем сообщение об ошибке и выводим его через маленькое окошечко
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

        private void mainLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
