using System;
using System.Collections.Generic;
using System.Text;
using EsportManagementApp.BusinessLogic;
using EsportManagementApp.Models;

namespace EsportManagementApp
{
    public class ProgramManager
    {
        private static string _availableCommands = "You can use the following commands next: \"asc\", \"desc\", \"add\", \"remove\" or \"exit\" to exit the app";

        private IOperations _operations;
        private IEnumerable<Player> _players;
        public ProgramManager(IOperations operations)
        {
            _operations = operations;
        }

        public void Run()
        {

            Console.WriteLine("works");
            _players = _operations.LoadPlayers();
            foreach (Player p in _players)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName);
            }
        }

        private void ExecuteUserInput(string input)
        {
            switch (input)
            {
                case "asc":
                case "desc":
                    //PrintPlayers(_databaseRepository.SortPlayers(input));
                    break;

                case "add":
                    //_databaseOperations.AddPlayer(CreateNewPlayer());
                    Console.WriteLine("New player added.");
                    Console.WriteLine(_availableCommands);
                    break;

                case "remove":
                    RemovePlayerInstruction();
                    break;

                case "exit":
                    Console.WriteLine("exit");
                    //_databaseOperations.SaveChanges();
                    Environment.Exit(0);
                    break;

                default:
                    PrintWrongInputMessage();
                    GetUserInput();
                    break;
            }
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void GreetUser()
        {
            Console.WriteLine("Welcome" + Environment.NewLine + _availableCommands);
        }

        private void PrintPlayers(IEnumerable<Player>players)
        {
            //TODO -> save the players in a list at the beggining of the app
            Console.WriteLine("..." + Environment.NewLine);

            foreach (Player player in players)
                Console.WriteLine(player.FirstName + "," + player.LastName + "," + player.Age + "," + player.Experience);

            Console.WriteLine("..." + Environment.NewLine);
        }

        private void PrintWrongInputMessage()
        {
            Console.WriteLine("Invalic command, please select a different command or exit" + Environment.NewLine + _availableCommands);
        }

        private Player CreateNewPlayer()
        {
            var newPlayer = new Player();

            Console.WriteLine("In order to add a player we need 4 infos: FirstName, LastName, Age, Experience. ");
            Console.WriteLine("Let's start with First Name, please write the player's first name:");

            newPlayer.FirstName = GetStringInputFromUser();

            Console.WriteLine("Great, now please enter the last name:");

            newPlayer.LastName = GetStringInputFromUser();

            Console.WriteLine("Now please add the age, numbers only!");

            newPlayer.Age = GetIntInputFromUser();

            Console.WriteLine("Last thing, add the player's experience, again numbers only!");

            newPlayer.Experience = GetIntInputFromUser();

            return newPlayer;
        }

        private string GetStringInputFromUser()
        {
            return GetUserInput(); 
        }

        private int GetIntInputFromUser()
        {
            int userInputAsInt;

            while (!int.TryParse(GetUserInput(), out userInputAsInt))
            {
                Console.WriteLine("Invalid entry, please add a number:");
            }

            return userInputAsInt;
        }

        private  void RemovePlayerInstruction()
        {
            Console.WriteLine("To remove a player please give us his/her First name and Lastname");
            Console.Write("Firstname:");

            var firstName = GetStringInputFromUser();

            Console.Write("Lastname:");

            var lastName = GetStringInputFromUser();

            //if (_databaseRepository.RemovePlayer(firstName, lastName))
            //{
            //    Console.WriteLine("Player removed.");

            //    Console.WriteLine(_availableCommands);
            //}
            //else
            //{
            //    Console.WriteLine("Player not found, if you want to try again please enter the \"remove\" command again");
            //}
        }
    }
}
