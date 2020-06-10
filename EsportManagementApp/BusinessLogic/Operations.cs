using EsportManagementApp.Database;
using EsportManagementApp.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EsportManagementApp.BusinessLogic
{
    public class Operations : IOperations
    {
        private IDatabaseRepository _databaseRepository;
        private static IList<Player> _localPlayers;

        public static IList<Player> LocalPlayers
        {
            get { return _localPlayers; }
            set { _localPlayers = value; }
        }

        public Operations(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public void PrintAllPlayersFromDatabase()
        {
            Console.WriteLine(_databaseRepository.GetPlayers());
        }

        private static IEnumerable<Player> SortPlayers(string orderBy)
        {
            yield return new Player();
            IEnumerable<Player> orderedPlayers = orderBy switch
            {
                "asc" => _localPlayers.OrderBy(x => x.FirstName),
                "desc" => _localPlayers.OrderByDescending(x => x.FirstName),
                _ => _localPlayers,
            };
            foreach (Player p in orderedPlayers)
            {
                yield return p;
            }
        }

        private static string GetCurrentPlayersInFormattedString()
        {
            var sb = new StringBuilder();
            foreach (Player p in LocalPlayers)
            {
                sb.AppendFormat("{0},{1},{2},{3}{4}", p.FirstName, p.LastName, p.Age, p.Experience, System.Environment.NewLine);
            }

            return sb.ToString();
        }
        
        private static void UpdateLocalPlayerListFromDbFile()
        {
            var players = new List<Player>();

            using (StreamReader sr = new StreamReader(Path.Combine("", "")))
            {
                while (sr.Peek() >= 0)
                {
                    string str;
                    string[] strArray;
                    str = sr.ReadLine();

                    strArray = str.Split(',');

                    Player currentPlayer = new Player();

                    currentPlayer.FirstName = strArray[0];
                    currentPlayer.LastName = strArray[1];
                    currentPlayer.Age = Convert.ToInt32(strArray[2]);
                    currentPlayer.Experience = Convert.ToInt32(strArray[3]);

                    players.Add(currentPlayer);
                }
            }

            _localPlayers = players;
        }

        public void AddPlayer(Player p)
        {
            throw new NotImplementedException();
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public List<Player> LoadPlayers()
        {
            throw new NotImplementedException();
        }

        public void RemovePlayer(Player p)
        {
            throw new NotImplementedException();
        }

        public static bool RemovePlayer(string name, string lastName)
        {
            var playerFound = false;
            var playerToRemove = _localPlayers.Where(x => x.FirstName == name && x.LastName == lastName).FirstOrDefault();

            if (playerToRemove != null)
            {
                _localPlayers.Remove(playerToRemove);

                playerFound = true;
            }

            return playerFound;
        }


        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
