using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;

namespace WebsiteProject
{
    public class DBUtil
    {
        private const string ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"|DataDirectory|\\Database.mdf\";Integrated Security=True;Connect Timeout=30";
        private SqlConnection connection;

        private Random rnd;

        public DBUtil()
        {
            connection = new SqlConnection(ConnectionString);
            rnd = new Random();
        }

        public User AddUser(string fullName, string userName, string password, string email)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("INSERT INTO Users (FullName, Username, Password, Email) OUTPUT Inserted.Id VALUES (N'{0}', N'{1}', N'{2}', '{3}')",
                fullName, userName, password, email);

            int id = -1;

            try
            {
                id = (int)command.ExecuteScalar();
                connection.Close();
            }
            catch (SqlException ex)
            {
                connection.Close();
                return null;
            }

            return new User(id, fullName, userName, password, email, 0, 0, 0, 0, 0);
        }

        public User GetUserByUsername(string username)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM Users WHERE (Username=N'{0}')", username);

            SqlDataReader reader = command.ExecuteReader();
            User user = null;

            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string fullName = reader.GetString(1);
                string password = reader.GetString(3);
                int solveCount = reader.GetInt32(4);
                int failCount = reader.GetInt32(5);
                int tofiCount = reader.GetInt32(6);
                float avgTypeSpeed = (float)reader.GetDouble(7);
                int rank = reader.GetInt32(8);
                string email = reader.GetString(9);

                user = new User(id, fullName, username, password, email, rank, tofiCount, solveCount, failCount, avgTypeSpeed);
            }

            connection.Close();

            return user;
        }

        public bool CheckLogIn(string username, string password)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM Users WHERE (Username=N'{0}' AND Password=N'{1}')",
                username, password);

            bool success = command.ExecuteReader().Read();

            connection.Close();

            return success;
        }

        public void UpdateUser(User user)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("UPDATE Users SET FullName=N'{0}', Username=N'{1}', Password=N'{2}', SolveCount={3}, FailCount={4}, TofiCount={5}, AvgTypeSpeed={6}, Rank={7}, Email='{8}'" +
                " WHERE (Username=N'{9}')", user.GetFullName(), user.GetUserName(), user.GetPassword(), user.GetSolveCount(), user.GetFailCount(), user.GetTofiCount(), user.GetAvgTypeSpeed(), user.GetRank(),
                user.GetEmail(), user.GetUserName());

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void DeleteUser(User user)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("DELETE FROM Users WHERE (Id={0})", user.GetId());

            command.ExecuteNonQuery();

            connection.Close();
        }

        public string GetRankName(int rank)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM Ranks WHERE (Id = {0})", rank);

            SqlDataReader reader = command.ExecuteReader();

            string rankName = null;

            if (reader.Read())
                rankName = reader.GetString(1);

            connection.Close();

            return rankName;
        }

        public int GetRankFromTofiCount(int tofiCount)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM Ranks WHERE (RankTofiCount <= {0}) ORDER BY Id ASC", tofiCount);

            SqlDataReader reader = command.ExecuteReader();

            int rank = 0;

            while (reader.Read())
                rank = reader.GetInt32(0);

            connection.Close();

            return rank;
        }

        public Verse GetRandomVerse()
        {
            const int MIN = 4021;
            const int MAX = 5524;
            
            int id = rnd.Next(MIN, MAX + 1);

            return GetVerseById(id);
        }

        public Verse GetVerseById(int id)
        {
            connection.Open();
            
            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("SELECT * FROM Verses WHERE (Id = {0})", id);
            SqlDataReader reader = command.ExecuteReader();

            Verse result = null;

            if (reader.Read())
                result = new Verse(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), (float)reader.GetDouble(3));

            connection.Close();

            return result;
        }

        public void UpdateVerse(Verse verse)
        {
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = String.Format("UPDATE Verses SET BestTime = {0} WHERE (Id={1})", verse.GetBestTime(), verse.GetId());

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}