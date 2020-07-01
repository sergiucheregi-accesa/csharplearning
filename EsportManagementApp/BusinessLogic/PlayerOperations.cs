using EsportManagementApp.Models;
using EsportManagementApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EsportManagementApp.BusinessLogic
{
    public class PlayerOperations : IOperations
    {
        private IDataService<Player> _databaseRepository;
        private static IList<Player> _localPlayers;

        public static IList<Player> LocalPlayers
        {
            get { return _localPlayers; }
            set { _localPlayers = value; }
        }

        public PlayerOperations(IDataService<Player> databaseRepository)
        {
            _databaseRepository = databaseRepository;
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

        }

        //public void PrintAllPlayersFromDatabase()
        //{
        //    Console.WriteLine(_databaseRepository.GetPlayers());
        //}

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
       

    }
}
