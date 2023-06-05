using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Figures
{
    /// <summary>
    /// Интерфейс игровой фигуры
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// Событие хода. Вызывается после завершения хода фигурой
        /// </summary>
        event MoveDelegate Move;
        /// <summary>
        /// Функция получения карты возможных ходов.
        /// </summary>
        /// <param name="board">Байтовая карта игрового поля.
        /// Значение элемента - номер команды фигуры в чейке этого поля.
        /// Значение 0 - ячейка свободна</param>
        /// <returns>Карта возможных ходов. true - ход в ячейку возможен, false - нет.</returns>
        bool[][] PossibleMove(byte[][] board);
        /// <summary>
        /// Сделать ход фигурой
        /// </summary>
        /// <param name="x">Координата по горизонтали</param>
        /// <param name="y">Координата по вертикали</param>
        void MakeMove(int x, int y);
        /// <summary>
        /// Получение позиции фигуры
        /// </summary>
        (int x, int y) position { get; }
        /// <summary>
        /// Получение номера команды фигуры
        /// </summary>
        byte team { get; } // 1 - белые, 2 - черные
    }
}
