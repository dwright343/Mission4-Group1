// Mission 4 // Section 4 Group 1

// HEAD
using System;

public class Driver
{
    int currPlayer = 1;

    static void Main()
    {
        //declare variables
        char[][] board = new char[3][];

        //initialize board array
        board[0] = new char[] {' ', ' ', ' '};
        board[1] = new char[] {' ', ' ', ' '};
        board[2] = new char[] {' ', ' ', ' '};

        //welcome message
        Console.WriteLine("Welcome to Tic Tac Toe!");
    }

    public void GetPlayerMove()
    {
        //set up variables
        string choice = " ";
        int choiceLocation = 0;
        bool isValidLocation;

        Console.WriteLine("Player " + currPlayer + ", enter your choice of X or O:");
        choice = Console.ReadLine().ToUpper();
        Console.WriteLine("Player " + currPlayer + ", enter your the location of your choice:");
        isValidLocation = int.TryParse(Console.ReadLine(), out choiceLocation);

    }
    
}
//=======
//Change
//>>>>>>> 10a570c330b6768d9dab01679a09c11d341b49f3
