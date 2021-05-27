using System;
using System.Globalization;
using TicTacToe.UI;
using Xunit;

namespace TicTacToe
{
    public class GameBoardSpecification
    {

        [Fact]
        public void InitialiseBoard_FirstCharacter ()
        {

            var initialBoardSetup = "X";
            var gameBoard = new GameBoard(initialBoardSetup);
            // player 1 wins
            Assert.Equal("X", gameBoard[0, 0]);

        }

        [Fact]

        public void InitialiseBoard_SecondChar()
        {

            var initialBoardSetup = " X";
            var gameBoard = new GameBoard(initialBoardSetup);
            // player 1 wins
            Assert.Equal("X", gameBoard[1, 0]);

        }


        [Fact]
        public void InitialiseBoard_SetFirstCharacter_ReadFirstCharacter_AsExpected()
        {

            var initialBoardSetup = "X";
            var gameBoard = new GameBoard(initialBoardSetup);
            // player 1 wins
            Assert.Equal("X", gameBoard[0, 0]);

        }


        [Fact]
        public void InitialiseBoard_SetLastCharacter_ReadLastCharacter_AsExpected()
        {

            var initialBoardSetup = "   " +
                                    "   " +
                                    "  X";

            var gameBoard = new GameBoard(initialBoardSetup);


            // player 1 wins

            Assert.Equal("X", gameBoard[2, 2]);

        }

    }



    




    
}
