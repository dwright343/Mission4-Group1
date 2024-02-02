using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission4
{
    // The supporting class is named Support
    internal class Support
    {
        // Receive the “board” array from the driver class
        public Support(char[][] board) 
        { 

        }

        // Contain a method that prints the board based on the information passed to it
        public void PrintBoard(Array board)
        {

        }

        // Contain a method that receives the game board array as input and returns if there 
        // is a winner and who it was
        public string WinnerCheck(char[][] board)
        {
            string sWinner = string.Empty;
            // Check the rows & columns for a win
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][0] == board[i][1] && board[i][1] == board[i][2]) 
                {
                    sWinner = $"Player {board[i][0]} wins!";
                }
                else if (board[0][i] == board[1][i] && board[1][i] == board[2][i])
                {
                    sWinner = $"Player {board[0][i]} wins!";
                }
            }
            // Check the diagonals for a win
            if (board[0][0] == board[1][1] && board[1][1] == board[2][2])
            {
                sWinner = $"Player {board[0][0]} wins!";
            }
            else if (board[0][2] == board[1][1] && board[1][1] == board[2][0])
            {
                sWinner = $"Player {board[0][2]} wins!";
            }
            return sWinner;
        }
    }
}
