using EntityFrameworkLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EsportManagementApp.BusinessLogic
{
    public interface IPlayerOperations
    {
        void Initialise();
        IEnumerable<Player> GetPlayers();
        Task AddPlayer(Player p);
        Task RemovePlayer(Player p);
    }
}
