using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using burgershack_c.Models;
using Dapper;
using MySql.Data.MySqlClient;


namespace burgershack_c.Repositories
{
    public class DrinkRepository
    {
        private string _connectionString;

        public DrinkRepository()
        {
            // _connectionString = "Server=DESKTOP-P9K6TD5:49172;Database=burgershack;User Id=student;Password=student;"; // WINDOWS SQL SERVER
            _connectionString = "server=192.168.0.2;port=3306;database=burgershack;user id=student;password=student;"; // MAC MYSQL
        }

        public IDbConnection Connection
        {
            get
            {
                // return new SqlConnection(_connectionString); // WINDOWS SQL SERVER
                return new MySqlConnection(_connectionString); // MAC MYSQL
            }
        }

        // Find One Find Many add update delete

        public IEnumerable<Drink> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Drink>("SELECT * FROM Drinks");
            }
        }

        public Drink GetById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.QueryFirstOrDefault<Drink>($"SELECT * FROM Drinks WHERE id = {id}");
            }
        }

        public Drink Add(Drink drink)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                int id = dbConnection.ExecuteScalar<int>("INSERT INTO Drinks (Name, Description, Price)"
                            + " VALUES(@Name, @Description, @Price); SELECT LAST_INSERT_ID()", drink);
                drink.Id = id;
                return drink;
            }
        }

        public Drink GetOneByIdAndUpdate(int id, Drink drink)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.QueryFirstOrDefault<Drink>($@"
                UPDATE Drinks SET  
                    Name = @Name,
                    Description = @Description,
                    Price = @Price
                WHERE Id = {id};
                SELECT * FROM Drinks WHERE id = {id}", drink);
            }
        }

    }
}