using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.UI;
using Xunit;

namespace TicTacToe
{
    public class RulesSpecificationTest
    {
        Game game = new Game();

        [Fact]
        public void GetWinner_MarkersTheSameIn1stRow()
        {

            var initialBoardSetup = "XXX" +
                                    "   " +
                                    "   " ;

            game = new Game(initialBoardSetup);

            // player 1 wins


            Assert.True(game.GetWinner() == "X");
        }
        [Fact]

        public void GetWinner_MarkersTheSameIn2ndRow()
        {

            var initialBoardSetup = "   " +
                                    "XXX" +
                                    "   ";

            game = new Game(initialBoardSetup);
            // player 1 wins
            Assert.Equal("X", game.GetWinner());

        }


        [Fact]

        public void GetWinner_MarkersTheSameIn3rgRow()
        {

            var initialBoardSetup = "   " +
                                    "   " +
                                    "XXX";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.X.ToString(), game.GetWinner());

        }

        [Fact]

        public void GetWinner_MarkersTheSameIn3rgRow_WithO()
        {

            var initialBoardSetup = "   " +
                                    "   " +
                                    "OOO";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.O.ToString(), game.GetWinner());

        }
             [Fact]
        public void GetWinner_MarkersTheSameIn1stColumn_WithO()
        {

            var initialBoardSetup = "O  " +
                                    "O  " +
                                    "O  ";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.O.ToString(), game.GetWinner());

        }
            [Fact]
        public void GetWinner_MarkersAreFirstDaigonal_WithO()
        {

            var initialBoardSetup = "O  " +
                                    " O " +
                                    "  O";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.O.ToString(), game.GetWinner());

        }
          [Fact]
        public void GetWinner_MarkersAreSecondDaigonal_WithO()
        {

            var initialBoardSetup = "  O" +
                                    " O " +
                                    "O  " ;


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.O.ToString(), game.GetWinner());

        }

        [Fact]
        public void GetWinner_MarkersAreFirstDaigonal_WithX()
        {

            var initialBoardSetup = "X  " +
                                    " X " +
                                    "  X";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.X.ToString(), game.GetWinner());

        }
        [Fact]
        public void GetWinner_MarkersAreSecondDaigonal_WithX()
        {

            var initialBoardSetup = "  X" +
                                    " X " +
                                    "X  ";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.X.ToString(), game.GetWinner());

        }
        [Fact]
        public void NoWinner_MarkersAreFirstDaigonal_WithO()
        {

            var initialBoardSetup = "OXO" +
                                    "OXX" +
                                    "XOO";


            game = new Game(initialBoardSetup);
            Assert.Equal(GameStatus.D.ToString(), game.GetWinner());

        }


    }
}
