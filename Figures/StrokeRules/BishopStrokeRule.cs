using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Boards;

namespace ChessGame.Figures.StrokeRules
{
    internal class BishopStrokeRule : IStrokeRule
    {
        private bool[][] PossibleMoveMap;
        private byte team;
        public BishopStrokeRule(byte team)
        {
            this.team = team;
        }
        public bool[][] PossibleMove(IBoard board, int x, int y)
        {
            for (int i = 0; i < board.lenghtX(); i++)
                for (int j = 0; j < board.lenghtY(8); j++)
                    PossibleMoveMap[i][j] = false;

            byte[][] teamMap = board.GetTeamMap();

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
