<<<<<<< Updated upstream
﻿// Mission 4 // Section 4 Group 1

=======
﻿
public class Support
{
    public static void PrintBoard(char[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            Console.Write(board[i] + " ");
            if ((i + 1) % 3 == 0) Console.WriteLine();
        }
    }

    public static bool WinnerCheck(char[] board)
    {
        int[,] winCombinations = new int[,] {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8},
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8},
            {0, 4, 8}, {2, 4, 6}
        };

        for (int i = 0; i < winCombinations.GetLength(0); i++)
        {
            if (board[winCombinations[i, 0]] == board[winCombinations[i, 1]] &&
                board[winCombinations[i, 1]] == board[winCombinations[i, 2]] &&
                board[winCombinations[i, 0]] != '.')
            {
                return true;
            }
        }
        return false;
    }

    public static void PrintNewBoard(char[] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            board[i] = (char)('1' + i);
        }
    }
}



class Driver
{
    private static char[] board = new char[9];
    private static int turns = 0;

    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        Support.PrintNewBoard(board); 
        bool isGameRunning = true;

        while (isGameRunning && turns < 9)
        {
            Support.PrintBoard(board);
            PlayerTurn(turns % 2 == 0 ? 'X' : 'O');
            isGameRunning = !Support.WinnerCheck(board);
            turns++;
        }

        Support.PrintBoard(board); // Display final board state
        if (!isGameRunning) Console.WriteLine($"Player {(turns % 2 == 0 ? 'O' : 'X')} wins!");
        else Console.WriteLine("It's a draw!");
    }

    static void PrintWelcomeMessage()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");
    }


    static void PlayerTurn(char player)
    {
        int choice;
        bool validMove;
        do
        {
            Console.WriteLine($"Player {player}, choose your slot (1-9): ");
            choice = int.Parse(Console.ReadLine()) - 1; // Adjust for zero-based index
            validMove = choice >= 0 && choice < 9 && board[choice] >= '1' && board[choice] <= '9';
            if (!validMove) Console.WriteLine("Invalid move, try again.");
        } while (!validMove);

        board[choice] = player;
    }
}
>>>>>>> Stashed changes
