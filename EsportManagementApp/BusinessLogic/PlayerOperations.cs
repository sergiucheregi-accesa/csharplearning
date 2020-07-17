using EsportManagementApp.Models;
using EsportManagementApp.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportManagementApp.BusinessLogic
{
    public class PlayerOperations : IOperations
    {
        private IDataService<Player> _databaseRepository;
        private static IEnumerable<Player> _localPlayers;

        public PlayerOperations(IDataService<Player> databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }

        public void AddPlayer(Player p)
        {
            _databaseRepository.Create(p);
        }

        public void Initialise()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Player> LoadPlayers()
        {
             _localPlayers = _databaseRepository.GetAll().Result;

            return _localPlayers;
        }

        public void RemovePlayer(Player p)
        {
            _databaseRepository.Delete(p);
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
            foreach (Player p in _localPlayers)
            {
                sb.AppendFormat("{0},{1},{2},{3}{4}", p.FirstName, p.LastName, p.Age, p.Experience, System.Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
