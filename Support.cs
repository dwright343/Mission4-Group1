using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission4
{
    // The supporting class is named Support
    internal class Support
    {
        public Support()
        {
        }

        // Receive the “board” array from the driver class
        public Support(char[][] board)
        {

        }

        // Contain a method that prints the board based on the information passed to it
        public string PrintNewBoard()//char[][] board)
        {
            int iOption = 0;

            for (int iOuter = 0; iOuter < 3; iOuter++)
            {
                for (int iInner = 0; iInner < 3; iInner++)
                {
                    Console.Write(++iOption);

                    if (iInner < 2)
                    {
                        Console.Write(" | ");
                    }
                    else
                    {
                        Console.Write("");
                    }
                }

                Console.WriteLine("");

                if (iOuter < 2)
                {
                    Console.WriteLine("----------");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            string sn = string.Empty;
            return sn;

        }

        public string UpdateBoard(string[] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.Write(board[i]);

                //2,5,8 represent slots 3,6,9
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(" | ");
                }

                if (i == 2 || i == 5)
                {
                    Console.WriteLine("----------");
                }
            }

            string ub = string.Empty;
            return ub;
        }



        // Contain a method that receives the game board array as input and returns if there 
        // is a winner and who it was
        public string WinnerCheck(string[] board)
        {

            string sWinner = string.Empty;

            // Check the rows & columns for a win
            for (int i = 0; i < 3; i++)
            {
                if (board[i * 3] == board[i * 3 + 1] && board[i * 3 + 1] == board[i * 3 + 2])
                {
                    sWinner = $"Player {board[i]} wins!";
                }
                else if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                {
                    sWinner = $"Player {board[i]} wins!";
                }
            }
            // Check the diagonals for a win

            if (board[0] == board[4] && board[4] == board[8])
            {
                sWinner = $"Player {board[0]} wins!";
            }
            else if (board[2] == board[4] && board[4] == board[6])
            {
                sWinner = $"Player {board[2]} wins!";
            }

            return sWinner;
        }

    } 
}
