using ChessGame.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures.StrokeRules
{
    internal class KingStrokeRule : IStrokeRule
    {
        private bool[][] PossibleMoveMap;
        private byte team;

        public KingStrokeRule(byte team)
        {
            this.team = team;
        }
        public bool[][] PossibleMove(IBoard board, int x, int y)
        {
            for (int i = 0; i < board.lenghtX(); i++)
                for (int j = 0; j < board.lenghtY(8); j++)
                    PossibleMoveMap[i][j] = false;

            byte[][] teamMap = board.GetTeamMap();

            for(int i = x-1; i < x+2 && i < 8; i++)
            {
                for(int j = y-1; j < y+2 && j < 8; j++)
                {
                    if (i < 0) i = i + 1;
                    if (j < 0) j = j + 1;
                    if (i == x && j == y)
                        continue;

                    if (teamMap[i][j] != team)
                        PossibleMoveMap[i][j] = true;
                    else
                        PossibleMoveMap[i][j] = false;

                }
            }
            return PossibleMoveMap;   
        }
    }
}
