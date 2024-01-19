using System.Data.SqlClient;

namespace DatingProgram.Data
{
    internal class DataBase
    {
        // подключение к базе в виде свойства (можно получить значение поля, но нельзя его изменить)
        public SqlConnection Access => sqlConnection;

        // приватное поле, спрятанное от других классов
        private SqlConnection sqlConnection;
        
        public DataBase()
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDb)\dateAgencies;Initial Catalog=Profiles;Integrated Security=True");
        }

        // Открываем базу, чтобы с ней поработать
        public void Open()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        // Закрываем базу после того как с ней поработали
        public void Close() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        // Метод возвращает подключение (аналог свойства в самом верху)
        public SqlConnection GetAccess()
        {
            return sqlConnection;
        }
    }
}
