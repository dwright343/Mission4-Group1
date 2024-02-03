
// Mission 4 // Section 4 Group 1
/*
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
*/


using Mission4;

class Driver
{
    public static char[] board = new char[9];
    private static int turns = 0;
    public static int[] aUsed = new int[9];

    static void Main(string[] args)
    {
        Support sp = new Support();
        PrintWelcomeMessage();
        sp.PrintNewBoard(); 
        bool isGameRunning = true;
        board = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

        while (isGameRunning && turns < 9)
        {
            PlayerTurn(turns % 2 == 0 ? 'X' : 'O');
            isGameRunning = !sp.WinnerCheck(board);
            turns++;
            sp.UpdateBoard(board);
        }

        sp.UpdateBoard(board); // Display final board state
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
        bool validMove = false;
        do
        {
            Console.WriteLine($"Player {player}, choose your slot (1-9): ");
            string input = (Console.ReadLine()); 
            
            if (int.TryParse(input, out choice) && (choice - 1 >= 0 && choice - 1 < 9) && (!aUsed.Contains(choice)) )
            {
                validMove = true;
                aUsed[turns] = choice;
            }
            else
            {
                validMove = false;
                Console.WriteLine("Invalid move, try again.");
            }
        } while (!validMove);
        board[choice -1] = player; // Adjust for zero-based index
    }
}