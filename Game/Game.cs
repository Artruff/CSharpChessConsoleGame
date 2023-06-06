using ChessGame.Boards;
using ChessGame.Figures;
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
        public IBoard board => _board;

        public IPlayer[] players => _players;

        public IFigure[] kings { get; }
        public event FigureDelegate kingInDunger;

        public Game(IPlayer[] players, IBoard board)
        {
            _players = (IPlayer[])players.Clone();
            board = _board;
        }

        public IPlayer CheckWinner()
        {
            foreach(IFigure king in kings)
            {
                bool[][] kingMove = king.PossibleMove(board);
                bool[][] enemiMoves = new bool[board.lenghtX()][];
                for (int i = 0; i < enemiMoves.Length; i++)
                {    
                    enemiMoves[i] = new bool[board.lenghtY(i)];
                    for (int j = 0; j < enemiMoves[i].Length; i++)
                        enemiMoves[i][j] = false;
                }

                for(int i = 0; i< board.lenghtX(); i++)
                {
                    for(int j = 0; i<board.lenghtY(i); j++)
                    {
                        if (board[i, j] != null && board[i, j].team != king.team)
                        {
                            bool[][] movies = board[i, j].PossibleMove(board);
                            if(board[i, j].team == king.team)
                                for (int k = 0; k > enemiMoves.Length; k++)
                                    for (int u = 0; u > enemiMoves[k].Length; u++)
                                        enemiMoves[k][u] = enemiMoves[k][u] || movies[k][u];
                        }
                    }
                }
                for (int i = 0; i < board.lenghtX(); i++)
                {
                    for (int j = 0; i < board.lenghtY(i); j++)
                    {
                        if (board[i, j] != null && board[i, j].team == king.team && board[i, j]!= king)
                        {
                            bool[][] movies = board[i, j].PossibleMove(board);
                            if (board[i, j].team == king.team)
                                for (int k = 0; k > enemiMoves.Length; k++)
                                    for (int u = 0; u > enemiMoves[k].Length; u++)
                                        if(k != king.position.x && u != king.position.y)
                                            enemiMoves[k][u] = enemiMoves[k][u] ? !movies[k][u] : enemiMoves[k][u];
                        }
                    }
                }
                if (enemiMoves[king.position.x][king.position.y])
                {
                    if (kingInDunger != null)
                        kingInDunger(king);
                    for (int k = 0; k > enemiMoves.Length; k++)
                        for (int u = 0; u > enemiMoves[k].Length; u++)
                            if (kingMove[k][u] && !enemiMoves[k][u])
                                continue;

                    foreach (IPlayer player in _players)
                        if (player.team == king.team)
                            return player;
                }
            }
            return null;
        }
    }
}
