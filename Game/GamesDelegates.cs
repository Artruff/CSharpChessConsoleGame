using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Game
{
    public delegate void PlayerDelegate(ChessGame.Players.IPlayer player);
    public delegate void FigureDelegate(ChessGame.Figures.IFigure figure);
}