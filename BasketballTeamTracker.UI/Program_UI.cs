using BasketballTeamTracker.POCO;
using BasketBallTeamTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.UI
{
    public class Program_UI
    {
        private readonly PlayerRepo _playerRepo = new PlayerRepo();

        public void Run()
        {
            //Seed();
            RunApplication();
        }

        private void Seed()
        {
            throw new NotImplementedException();
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Basketball Team Tracker\n" +
                    "1. Create Player\n" +
                    "2. View All Players\n" +
                    "3. View a Single Player\n" +
                    "4. Update an Existing Player\n" +
                    "5. Delete and Existing Player\n" +
                    "99. Close Application\n");
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Menu();
                // get user input
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreatePlayer();
                        break;
                    case "2":
                        ViewAllPlayers();
                        break;
                    default:
                        break;
                }

            }
        }

        private void ViewAllPlayers()
        {
            Console.Clear();

            List<Player> players = _playerRepo.GetPlayers();

            foreach (var player in players)
            {
                DisplayPlayerInfo(player);
            }
            Console.ReadKey();
        }

        private void DisplayPlayerInfo(Player player)
        {
            Console.WriteLine($"{player.ID}\n" +
                $"{player.FirstName}\n" +
                $"{player.PlayerPosition}\n");
            Console.WriteLine("**********************************");
        }

        private void CreatePlayer()
        {
            Console.Clear();

            // Get player name
            Console.WriteLine("Please input a player's first name: ");
            string userInputPlayerName = Console.ReadLine();

            // Get player position
            Console.WriteLine("Please input a player position:\n" +
                "1. Point Guard\n" +
                "2. Shooting Guard\n" +
                "3. Small Forward\n" +
                "4. Power Forward\n" +
                "5. Center\n");

            int userInputPlayerPosition = int.Parse(Console.ReadLine());

            //Now, we need to make a conversion from int to playerPositionType
            PlayerPositionType playerPosition = (PlayerPositionType)userInputPlayerPosition;

            //Construct the player
            Player playerToBeAddedToDataBase = new Player(userInputPlayerName, playerPosition);

            //Add the player to my Database
            bool isSuccessful = _playerRepo.CreatePlayer(playerToBeAddedToDataBase);

            if (isSuccessful)
            {
                Console.WriteLine($"{playerToBeAddedToDataBase.FirstName} was successfully created!");
            }
            else
            {
                Console.WriteLine($"{playerToBeAddedToDataBase.FirstName} was NOT successfully created!");

            }

        }
    }
}
