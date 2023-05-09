using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures
{
    /// <summary>
    /// Делегат хода фигруры
    /// </summary>
    /// <param name="figure">Фигура, сделавшая ход</param>
    public delegate void MoveDelegate(IFigure figure, int x, int y);
}
