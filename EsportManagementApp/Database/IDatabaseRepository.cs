using EsportManagementApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp.Database
{
    public interface IDatabaseRepository
    {
        void Initialise();
        List<Player> LoadPlayers();
        void AddPlayer(Player p);
        void RemovePlayer(Player p);
        void SaveChanges();
        string GetPlayers();
    }
}
