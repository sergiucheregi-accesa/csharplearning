using EsportManagementApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EsportManagementApp.BusinessLogic
{
    public interface IOperations
    {
        void Initialise();
        IEnumerable<Player> LoadPlayers();
        void AddPlayer(Player p);
        void RemovePlayer(Player p);
    }
}
