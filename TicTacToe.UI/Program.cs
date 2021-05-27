using System;
using System.Threading;

namespace TicTacToe.UI
{
    class Program
    {




        static int player = 1; //By default player 1 is set
        static int choice; //This holds the choice at which position user want to mark 




        static void Main(string[] args)
        {
            var initialSetup = "036147258";
            string winner;
            GameBoard board = new GameBoard(initialSetup);
            do
            {
                Console.Clear();// whenever loop will be again start then screen will be clear
                Console.WriteLine("Player 1 is :X and Player 2 is :O");
                Console.WriteLine("\n");
                if (player % 2 == 0)//checking the chance of the player
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                DisplayBoard(initialSetup);// calling the board Function

               choice = int.Parse(Console.ReadLine());//Taking users choice 
                // checking that position where user want to run is marked (with X or O) or not
                // convert choice to x , y
                int y = choice % 3;
                int x = choice / 3;

                // So that user cant enter on same cell twice
                if (board[x, y] != "X" && board[x, y] != "O")
                    if (board[x, y] != "X" && board[x, y] != "X")
                    {
                        if (player % 2 == 0) //if chance is of player 2 then mark O else mark X
                        {
                            board[x, y] = "O";
                            player++;
                        }
                        else
                        {
                            board[x, y] = "X";
                            player++;
                        }
                    }
                    else //If there is any possition where user want to run and that is already marked then show message and load board again
                    {
                        Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, board[x, y]);
                        Console.WriteLine("\n");
                        Console.WriteLine("Please wait 2 second board is loading again.....");
                         
                        Thread.Sleep(2000);
                    }

                    initialSetup = initialSetup.Replace(choice.ToString(), board[x, y]);
                    board = new GameBoard(initialSetup);
                    var game = new Game(initialSetup);
                    winner = game.GetWinner();

            } while (winner != GameStatus.X.ToString() && winner != GameStatus.O.ToString() && winner != GameStatus.D.ToString());// This loof will be run until all cell of the grid is not marked with X and O or some player is not win

            Console.Clear();// clearing the console

            DisplayBoard(initialSetup);// getting filled board again

            if (winner == GameStatus.X.ToString() || winner == GameStatus.O.ToString())// if flag value is 1 then some one has win or means who played marked last time which has win
            {
                Console.WriteLine("Player {0} : {1} has won", (player % 2) + 1, winner);
            }
            else if (winner == GameStatus.D.ToString()) // if flag value is -1 the match will be draw and no one is winner
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }



        // Board method which creats board

        private static void DisplayBoard(string initialSetup)
        {

            var board = new GameBoard(initialSetup);

            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |      ");


        }
    }
         
}
