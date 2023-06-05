using ChessGame.Boards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures.StrokeRules
{
    internal class QueenStrokeRule : IStrokeRule
    {
        private bool[][] PossibleMoveMap;
        private byte team;

        public QueenStrokeRule(byte team)
        {
            this.team = team;
        }
        public bool[][] PossibleMove(IBoard board, int x, int y)
        {
            for (int i = 0; i < board.lenghtX(); i++)
                for (int j = 0; j < board.lenghtY(8); j++)
                    PossibleMoveMap[i][j] = false;

            byte[][] teamMap = board.GetTeamMap();
            
            // как ладья
            for (int j = y + 1; j < board.lenghtY(8); j++)
            {
                int i = x;
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }
            for (int j = y - 1; j > board.lenghtY(0); j--)
            {
                int i = x;
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }


            for (int i = x + 1; i < board.lenghtY(8); x++)
            {
                int j = y;
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }
            for (int i = x - 1; i > board.lenghtY(0); x--)
            {
                int j = y;
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }

            // как слон
            for (int i = x - 1, j = y - 1; i > board.lenghtX() && j > board.lenghtY(0); i--, j--)
            {
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }
            for (int i = x - 1, j = y + 1; i > board.lenghtX() && j < board.lenghtY(8); i--, j++)
            {
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }
            for (int i = x + 1, j = y - 1; i < board.lenghtX() && j > board.lenghtY(0); i++, j--)
            {
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }
            for (int i = x + 1, j = y + 1; i < board.lenghtX() && j < board.lenghtY(8); i++, j++)
            {
                if (teamMap[i][j] == team)
                {
                    PossibleMoveMap[i][j] = false;
                    break;
                }
                else
                    PossibleMoveMap[i][j] = true;
            }

            return PossibleMoveMap;
        }
    }
}
