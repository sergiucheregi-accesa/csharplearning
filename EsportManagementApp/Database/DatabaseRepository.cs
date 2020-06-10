using EsportManagementApp.BusinessLogic;
using EsportManagementApp.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace EsportManagementApp.Database
{
    public class DatabaseRepository : IDatabaseRepository
    {
        private static IList<Player> _localPlayers;
        private static SqliteConnection _localDbConnection;

        public static IList<Player> LocalPlayers
        {
            get => _localPlayers;
            set => _localPlayers = value;
        }

        public void Initialise()
        {

        }

        public string GetPlayers()
        {
            var players = "";

            CreateConnection();

            var sqliteCmd = _localDbConnection.CreateCommand();
            sqliteCmd.CommandText = "SELECT * FROM Player";

            var sqliteDataReader = sqliteCmd.ExecuteReader();  

            while (sqliteDataReader.Read())
            {
                var reader = sqliteDataReader.GetString(1);
                players = players + reader + Environment.NewLine;
            }

            _localDbConnection.Close();

            return players;
        }

        public static void SaveDatabase()
        {

        }

        public void AddPlayer(Player p)
        {
            
        }

        public void RemovePlayer(Player p)
        {
            
        }

        public List<Player> LoadPlayers()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        private static void CreateConnection()
        {
            _localDbConnection = new SqliteConnection("Data Source = .\\EsportMgmtDatabase.db;");

            try
            {
                _localDbConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection to DB failed: {ex.Message}");
            }
        }
    }
}
