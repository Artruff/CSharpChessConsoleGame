using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Players
{
    public class Player : IPlayer
    {
        private string _name;
        private byte _team;
        public Player(string name, byte team)
        {
            _name = name;
            if (team < 1)
                throw new ArgumentException("Wrong value team. Team cant be negative.");
            _team = team;
        }

        public string name => _name;

        public byte team => _team;
    }
}
