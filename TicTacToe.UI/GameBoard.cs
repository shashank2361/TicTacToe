using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TicTacToe.UI
{

    public class GameBoard : IEnumerable
    {
        private readonly string[,] board = new string[3, 3];


        public GameBoard(string initialBoardSetup)
        {
            int i = 0;
            foreach (var singleChar in initialBoardSetup)
            {
                this.board[i % 3, i / 3] = singleChar.ToString(CultureInfo.InvariantCulture);
                i++;
            }
        }

        public string this[int x, int y]
        {
            get
            {
                return this.board[x, y];
            }
            set
            {
                this.board[x, y] = value;
            }
        }

        public IEnumerator GetEnumerator()
        {
                return board.GetEnumerator();       
        }
    }
}