using ChessGame.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures.StrokeRules
{
    internal class PawnStrokeRule : IStrokeRule
    {
        private bool[][] PossibleMoveMap;
        private byte team;
        public PawnStrokeRule(byte team)
        {
            this.team = team;
        }
        public bool[][] PossibleMove(IBoard board, int x, int y)
        {
            for (int i = 0; i < board.lenghtX(); i++)
                for (int j = 0; j < board.lenghtY(8); j++)
                    PossibleMoveMap[i][j] = false;

            PossibleMoveMap[x][y] = false;
            byte[][] teamMap = board.GetTeamMap();

            if(team == 1) // белые
            {
                if (teamMap[x - 1][y] == team)
                    PossibleMoveMap[x - 1][y] = false;
                else
                    PossibleMoveMap[x - 1][y] = true;
                if (x == 6)
                {
                    if (teamMap[x - 2][y] == team)
                        PossibleMoveMap[x - 2][y] = false;
                    else
                        PossibleMoveMap[x - 2][y] = true;
                }

                if(teamMap[x - 1][y -1] != team && teamMap[x - 1][y - 1] != 0)
                    PossibleMoveMap[x - 1][y-1] = true;
                else
                    PossibleMoveMap[x - 1][y - 1] = false;

                if (teamMap[x - 1][y + 1] != team && teamMap[x - 1][y + 1] != 0)
                    PossibleMoveMap[x - 1][y + 1] = true;
                else
                    PossibleMoveMap[x - 1][y + 1] = false;
            }
            else if(team == 2) // черные
            {
                if (teamMap[x + 1][y] == team)
                    PossibleMoveMap[x + 1][y] = false;
                else
                    PossibleMoveMap[x + 1][y] = true;
                if (x == 1)
                {
                    if (teamMap[x + 2][y] == team)
                        PossibleMoveMap[x + 2][y] = false;
                    else
                        PossibleMoveMap[x + 2][y] = true;
                }

                if (teamMap[x + 1][y - 1] != team && teamMap[x + 1][y - 1] != 0)
                    PossibleMoveMap[x + 1][y - 1] = true;
                else
                    PossibleMoveMap[x + 1][y - 1] = false;

                if (teamMap[x + 1][y + 1] != team && teamMap[x + 1][y + 1] != 0)
                    PossibleMoveMap[x + 1][y + 1] = true;
                else
                    PossibleMoveMap[x + 1][y + 1] = false;
            }
            
            return PossibleMoveMap;
        }
    }
}
