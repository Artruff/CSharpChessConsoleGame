using ChessGame.Figures.StrokeRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures
{
    public class Figure : IFigure
    {
        private int _x, _y;
        private byte _team;
        StrokeRules.IStrokeRule _strokeRule;

        public Figure(int x, int y, byte team, IStrokeRule strokeRule)
        {
            _x = x;
            _y = y;
            _team = team;
            _strokeRule = strokeRule;
        }

        public (int x, int y) position => (_x, _y);

        public byte team => _team;

        public event MoveDelegate Move;

        public void MakeMove(int x, int y)
        {
            _x = x;
            _y = y;
            Move?.Invoke(this, x, y);
        }

        public bool[][] PossibleMove(byte[][] board)
        {
            return _strokeRule.PossibleMove(board);
        }
    }
}
