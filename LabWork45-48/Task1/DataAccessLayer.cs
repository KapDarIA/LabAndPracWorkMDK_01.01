using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace Task1
{
    public static class DataAccessLayer
    {
        public static string DataSource { get; set; } = @"prserver\SQLEXPRESS";
        public static string UserID { get; set; } = "ispp2103";
        public static string Password { get; set; } = "2103";
        public static string InitialCatalog { get; set; } = "ispp2103";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = DataSource,
                    UserID = UserID,
                    Password = Password,
                    InitialCatalog = InitialCatalog,
                    TrustServerCertificate = true,
                };
                return builder.ConnectionString;
            }
        }

        public static object GetObject(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            return command.ExecuteScalar();
        }

        public static DataTable GetTable(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            DataTable table = new();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.Fill(table);
            return table;
        }

        public static List<Book> GetBooks()
        {
            string query = "SELECT * FROM Book";
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);
            var reader = command.ExecuteReader();
            List<Book> books = new();
            while (reader.Read())
            {
                Book book = new()
                {
                    Id = reader.GetInt32("BookId"),
                    Price = Convert.ToDouble(reader.GetDecimal("Price")),
                    Title = reader.GetString("Title"),
                };
                books.Add(book);
            }
            return books;
        }

        //46
        //Task1 возвращает количество измененных командой строк. 

        public static int GetCountChangedRows(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery();
        }

        //Task2 Изменение цены книги

        public static bool UpdatePrice(int bookId, decimal price)
        {
            if (price < 0 || bookId < 0)
                return false;

            string query = $"UPDATE Book SET Price = {price} WHERE BookId = {bookId}";

            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery() > 0;
        }

        //Task3 возращение таблицы по имени

        public static DataTable GetTableByName(string nameTable)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            string query = $"SELECT * FROM {nameTable}";

            DataTable table = new();
            using SqlDataAdapter adapter = new(query, connection);

            adapter.Fill(table);
            return table;
        }

        //Task4 

        public static void UpdateTable(ref DataTable table, string nameTable)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT * FROM {nameTable}";

            using SqlDataAdapter adapter = new(query, connection);
            SqlCommandBuilder builder = new(adapter);

            adapter.Update(table);
            table.Clear();
            adapter.Fill(table);
        }

        //47
        //Task1 возвращает количество книг с ценой, меньше указанной в параметрах.

        public static int GetBooksCountByPrice(decimal price)
        {
            if (price < 0)
                return -1;

            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = $"SELECT COUNT(*) FROM Book WHERE Price < @price";

            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@price", price);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        //Task2 возвращает идентификатор добавленной записи.

        public static int GetNewRecordId(string query)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            query += ";SET @Id=SCOPE_IDENTITY()";

            SqlCommand command = new(query, connection);
            SqlParameter lastId = new("@id", DbType.Int32);
            lastId.Direction = ParameterDirection.Output;
            command.Parameters.Add(lastId);
            command.ExecuteNonQuery();
            return Convert.ToInt32(lastId.Value);
        }

        //Task3 возвращает в виде DataTable набор книг укказанного жанра с ценой, меньше
        //указанной в параметрах

        public static DataTable GetBooks(string genre, decimal price)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "SELECT * FROM Book WHERE Price < @Price AND Genre=@Genre";

            DataTable table = new DataTable();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@genre", genre);
            adapter.SelectCommand.Parameters.AddWithValue("@price", price);
            adapter.Fill(table);
            return table;
        }

        //Task4 возвращает информацию о том, удалось ли изменить данные.

        public static bool ChangeBookById(int id, decimal price, string title)
        {
            if (id <= 0 || price < 0 || title.IsNullOrEmpty() == true)
                return false;

            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "UPDATE Book SET Price = @Price, Title = @Title WHERE BookId = @Id";

            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@title", title);

            return command.ExecuteNonQuery() > 0;
        }

        //48
        //Task2 добавляет автора в таблицу БД с использованием хранимой процедуры.

        public static void AddAuthor(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "AddAuthor";

            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);
            command.ExecuteNonQuery();
        }

        //Task3 возвращает идентификатор добавленного автора.

        public static int GetAuthorId(string surname, string name, string country)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "GetAuthorId";

            SqlCommand command = new(query, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@surname", surname);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@country", country);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        //Task4 возвращает в формате DataTable информацию о книгах с соответствующей ценой (диапазон)

        public static DataTable GetBooksPriceInRange(decimal firstPrice, decimal lastPrice)
        {
            using SqlConnection connection = new(ConnectionString);
            connection.Open();

            var query = "GetBooksPriceInRange";

            DataTable table = new DataTable();
            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@firstPrice", firstPrice);
            adapter.SelectCommand.Parameters.AddWithValue("@lastPrice", lastPrice);
            adapter.Fill(table);
            return table;
        }
    }
}