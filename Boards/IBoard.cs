using ChessGame.Figures;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Boards
{
    /// <summary>
    /// Интерфейс игровой доски
    /// </summary>
    public interface IBoard : IEnumerable, IEnumerator
    {
        /// <summary>
        /// Массив фигур на поле
        /// </summary>
        IFigure this[int x, int y] { get; set; }
        /// <summary>
        /// Получение командной карты поля
        /// </summary>
        /// <returns>Карта ячеек поля, где значение поля - номер команды фигуры в данной ячейке.
        /// 0 - ячейка пустая.</returns>
        byte[][] GetTeamMap();
        /// <summary>
        /// Получение длины поля по x
        /// </summary>
        /// <returns>Длина уровня x</returns>
        int lenghtX();
        /// <summary>
        /// Получение длины поля y на уровне x
        /// </summary>
        /// <param name="x">Уровень x</param>
        /// <returns>Длина уровня y</returns>
        int lenghtY(int x);
    }
}
