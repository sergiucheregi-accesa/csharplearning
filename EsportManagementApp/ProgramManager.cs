using System;
using System.Collections.Generic;
using System.Text;
using EsportManagementApp.BusinessLogic;
using EntityFrameworkLibrary.Models;

namespace EsportManagementApp
{
    public class ProgramManager
    {
        private IPlayerOperations _operations;
        private IEnumerable<Player> _players;

        public ProgramManager(IPlayerOperations operations)
        {
            _operations = operations;
        }

        public void Run()
        {
            _players = _operations.GetPlayers();

            foreach (Player p in _players)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }
    }
}
