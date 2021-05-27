using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TicTacToe.UI
{
    public class Game
    {

        private string prevMarker { get; set; }
        private readonly GameBoard board;

        public Game() : this("")
        {

        }
        public Game(string initialBoardSetup)
        {
            board = new GameBoard(initialBoardSetup);
        }

        public void Play(string marker, int x, int y)
        {

            if (marker == this.prevMarker)
            {
                throw new InvalidOperationException();
            }

            if (this.board[x, y] != null)
            {
                throw new InvalidOperationException();

            }

            this.prevMarker = marker;
            this.board[x, y] = marker;
        }


        public string GetWinner()
        {

              #region Horzontal Winning Condtion
            var row = 0;
            if (RowMarkersArethesame(row) && IsPlayer(0, row))
            {
                return this.board[0, row];
            }
            row = 1;
            if (RowMarkersArethesame(row) && IsPlayer(0, row))
            {
                return this.board[0, row];
            }
            row = 2;
            if (RowMarkersArethesame(row) && IsPlayer(0, row))
            {
                return this.board[0, row];
            }
             #endregion


              #region Vertical Winning Condtion
            var column = 0;

            if (ColumnMarersAreSame(column) && IsPlayer(column, 0))
            {
                return this.board[column, 0];
            }
            column = 1;
            if (RowMarkersArethesame(column) && IsPlayer(column, 0))
            {
                return this.board[column, 0];
            }
            column = 2;
            if (RowMarkersArethesame(column) && IsPlayer(column, 0))
            {
                return this.board[column, 0];
            }
             #endregion
                #region Daignoal Winning Condtion

            if (DaignolMArkersAreSame())
            {
                  return this.board[1, 1];
            }

 
             #region Draw Winning Condtion

           var noofFilledCells = 0;
            foreach (var item in this.board)
            {
                if (item.Equals(GameStatus.X.ToString()) || item.Equals(GameStatus.O.ToString() ))
                {
                    noofFilledCells++;

                }
            }

            if (noofFilledCells == 9)
            {
                 return GameStatus.D.ToString();
            }


             #endregion


            #region in process Condtion

            return GameStatus.P.ToString();


             #endregion
           
            //return this.board[0, 0];
            
            #endregion

        }

        private bool IsPlayer(int x, int y)
        {
            var s = this.board[x, y];
            return s == "X" || s == "O";
        }

        private bool RowMarkersArethesame(int row)
        {
            if ((this.board[0, row] == this.board[1, row]) && (this.board[1, row] == this.board[2, row]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool ColumnMarersAreSame(int column)
        {
            if ((this.board[column, 0] == this.board[column, 1]) && (this.board[column, 1] == this.board[column, 2]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool DaignolMArkersAreSame ( )
        {
            if ( (   ( this.board[0, 0] == this.board[1, 1]) && (this.board[1, 1] == this.board[2 , 2]  ) &&  IsPlayer(0,0 ) && IsPlayer(1,1 ) && IsPlayer(2,2 )   ) ||
               ( (this.board[2, 0] == this.board[1, 1]) && (this.board[1, 1] == this.board[0 , 2])   &&  IsPlayer(2,0 ) && IsPlayer(1,1 ) && IsPlayer(0,2 )   ) )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
} 