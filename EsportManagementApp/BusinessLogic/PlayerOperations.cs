using EntityFrameworkLibrary.Models;
using EntityFrameworkLibrary.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EsportManagementApp.BusinessLogic
{
    public class PlayerOperations : IPlayerOperations
    {
        private PlayerDataService _playerDataService;
        private IEnumerable<Player> _allPlayers;

        public PlayerOperations(PlayerDataService playerDataService)
        {
            _playerDataService = playerDataService;
        }

        public void Initialise()
        {
            
        }

        public IEnumerable<Player> GetPlayers()
        {
            var players = _playerDataService.GetAll().Result;

            return players;
        }

        public async Task AddPlayer(Player p)
        {
            await _playerDataService.Create(p);
        }

        public async Task RemovePlayer(Player p)
        {
            await _playerDataService.Delete(p);
        }
    }
}
