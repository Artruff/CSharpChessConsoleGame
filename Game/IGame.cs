using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessGame.Boards;
using ChessGame.Figures;
using ChessGame.Players;

namespace ChessGame.Game
{
    /// <summary>
    /// Интерфейс игры
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Игровая доска
        /// </summary>
        IBoard board { get; }
        /// <summary>
        /// Список игроков
        /// </summary>
        IPlayer[] players { get; }
        /// <summary>
        /// Ход текущего игрока
        /// </summary>
        IPlayer currentPlayer { get; }
        /// <summary>
        /// Запуск игры
        /// </summary>
        void Start();
    }
}