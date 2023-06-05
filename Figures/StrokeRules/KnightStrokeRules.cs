using ChessGame.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures.StrokeRules
{
    internal class KnightStrokeRules
    {
        private bool[][] PossibleMoveMap;
        private byte team;

        public KnightStrokeRules(byte team)
        {
            this.team = team;
        }
        public bool[][] PossibleMove(IBoard board, int x, int y)
        {
            for (int i = 0; i < board.lenghtX(); i++)
                for (int j = 0; j < board.lenghtY(8); j++)
                    PossibleMoveMap[i][j] = false;

            byte[][] teamMap = board.GetTeamMap();

            if (teamMap[x - 1][y - 2] == team)
                PossibleMoveMap[x - 1][y - 2] = false;
            else
                PossibleMoveMap[x - 1][y - 2] = true;
            if (teamMap[x - 2][y - 1] == team)
                PossibleMoveMap[x - 2][y - 1] = false;
            else
                PossibleMoveMap[x - 2][y - 1] = true;

            if (teamMap[x - 1][y + 2] == team)
                PossibleMoveMap[x - 1][y + 2] = false;
            else
                PossibleMoveMap[x - 1][y + 2] = true;
            if (teamMap[x - 2][y + 1] == team)
                PossibleMoveMap[x - 2][y + 1] = false;
            else
                PossibleMoveMap[x - 2][y + 1] = true;

            if (teamMap[x + 1][y - 2] == team)
                PossibleMoveMap[x + 1][y - 2] = false;
            else
                PossibleMoveMap[x + 1][y - 2] = true;
            if (teamMap[x + 2][y - 1] == team)
                PossibleMoveMap[x + 2][y - 1] = false;
            else
                PossibleMoveMap[x + 2][y - 1] = true;

            if (teamMap[x + 1][y + 2] == team)
                PossibleMoveMap[x + 1][y + 2] = false;
            else
                PossibleMoveMap[x + 1][y + 2] = true;
            if (teamMap[x + 2][y + 1] == team)
                PossibleMoveMap[x + 2][y + 1] = false;
            else
                PossibleMoveMap[x + 2][y + 1] = true;


            return PossibleMoveMap;
        }
    }
}
