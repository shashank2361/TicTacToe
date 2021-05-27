using System;
using System.Collections.Generic;
using System.Text;
using TicTacToe.UI;
using Xunit;

namespace TicTacToe.Test
{
    public class TicTacToeSpecifications
    {

        public readonly Game game = new Game();

        [Fact]
        public void ExampleGame_P1Wins_AllMarkerInOneRow()
        {
            game.Play("X", 0, 0);
            game.Play("O", 0, 1);
            game.Play("X", 1, 0);
            game.Play("O", 1, 1);
            game.Play("X", 2, 0);

            // player 1 wins
            Assert.True(game.GetWinner() == GameStatus.X.ToString());

        }


        [Fact]
        public void ExampleGame_P2Wins_AllMargersInOneRow()
        {
            game.Play("X", 2, 1);
            game.Play("O", 0, 0);
            game.Play("X", 1, 1);
            game.Play("O", 0, 1);
            game.Play("X", 2, 2);
            game.Play("O", 0, 2);

            // player 1 wins

            Assert.True(game.GetWinner() == "O");

        }

        //[Fact(Skip = "It's not ready yet")]
        [SkippableFact( typeof(InvalidOperationException))]
        public void MarkerAlreadyPlacedException()
        {

            game.Play("X", 0, 0);
            game.Play("O", 0, 0);



        }

        [Fact]
         public void OnlyOneMarkerSet_NoWinneryet()
        {
            // Assert.False(GetWinner)
            game.Play("X", 2, 1);
            Assert.True(game.GetWinner() == GameStatus.P.ToString());
        }





        ////[Fact]
        //[SkippableFact(typeof(NotSupportedException), typeof(InvalidOperationException))]
        //public void MadeBoardGeneric()
        //{

        //    //game.Play("X", 0, 0);
        //    //game.Play("O", 0, 0);



        //}



        //[Fact]
        //public void NicerApi()
        //{

        //    //game.Play("X", 0, 0);
        //    //game.Play("O", 0, 0);



        //}
    }
}