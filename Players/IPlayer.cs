using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessGame.Players
{
    /// <summary>
    /// Интерфейс игрока в шахматы
    /// </summary>
    public interface IPlayer
    {
        /// <summary>
        /// Имя игрока
        /// </summary>
        string name { get; }
        /// <summary>
        /// Номер команды игрока
        /// </summary>
        byte team { get; }
    }
}
