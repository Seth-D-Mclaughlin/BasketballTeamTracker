using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.POCO
{

    public class Player
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public PlayerPositionType PlayerPosition { get; set; }

        public Player()
        {

        }

        public Player(string firstName, PlayerPositionType playerPosition)
        {
            FirstName = firstName;
            PlayerPosition = playerPosition;
        }
    }
}
