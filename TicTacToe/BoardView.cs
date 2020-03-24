using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class BoardView
    {
        private readonly BoardModel _model;

        public BoardView(BoardModel model)
        {
            _model = model;
        }

        public string Show()
        {
            return
                "  a b c\r\n" +
                " ┌─────┐\r\n" +
                $"1│{GetSquare(0)} {GetSquare(1)} {GetSquare(2)}│\r\n" +
                $"2│{GetSquare(3)} {GetSquare(4)} {GetSquare(5)}│\r\n" +
                $"3│{GetSquare(6)} {GetSquare(7)} {GetSquare(8)}│\r\n" +
                " └─────┘";
        }

        char GetSquare(int index )
        {
            const string chars = " xo";
            var characterIndex = _model.GetSquare(index);
            return chars[characterIndex];
        }
    }
}
