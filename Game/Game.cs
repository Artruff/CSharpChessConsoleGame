using ChessGame.Boards;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Game
{
    public class Game : IGame
    {
        private IBoard _board;
        private IPlayer[] _players;
        private IPlayer _currentPlayer;
        public IBoard board => _board;

        public IPlayer[] players => _players;

        public IPlayer currentPlayer => _currentPlayer;

        public void Start()
        {
            
        }
    }
}
