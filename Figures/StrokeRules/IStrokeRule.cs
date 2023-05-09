using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures.StrokeRules
{
    public interface IStrokeRule
    {
        bool[][] PossibleMove(byte[][] board);
    }
}
