using ChessGame.Figures;
using System;
using System.Collections;

namespace ChessGame.Boards
{
    public class Board : IBoard
    {
        IFigure[][] _figures;
        public IFigure this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= _figures.Length)
                    throw new IndexOutOfRangeException();
                if (y < 0 || y >= _figures[x].Length)
                    throw new IndexOutOfRangeException();
                return _figures[x][y];
            }
            set
            {
                for (int _x = 0; _x < _figures.Length; x++)
                    for (int _y = 0; _y < _figures[x].Length; _y++)
                        if (_figures[_x][_y] == value)
                        {
                            _figures[_x][_y] = null;
                        }
                _figures[x][y] = value;
            }
        }
        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public byte[][] GetTeamMap()
        {
            byte[][] teamMap = new byte[_figures.Length][];
            for(int x = 0; x < teamMap.Length; x++)
            {
                teamMap[x] = new byte[_figures[x].Length];
                for (int y = 0; y < teamMap[x].Length; y++)
                    teamMap[x][y] = _figures[x][y].team;
            }
            return teamMap;
        }

        public int lenghtX()
        {
            return _figures.Length;
        }

        public int lenghtY(int x)
        {
            return _figures[x].Length;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
