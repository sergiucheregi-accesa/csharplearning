using EsportManagementApp.Models;
using System.Collections.Generic;

namespace EsportManagementApp.BusinessLogic
{
    public interface IOperations
    {
        void Initialise();
        List<Player> LoadPlayers();
        void AddPlayer(Player p);
        void RemovePlayer(Player p);
        void SaveChanges();
        //void PrintAllPlayersFromDatabase();
    }
}
