﻿// Mission 4 // Section 4 Group 1

using System.Runtime.InteropServices;
using Mission4;

Support ns = new Support();



ns.PrintNewBoard();

string[] options = ["X", "2", "3", "4", "X", "6", "7", "8", "X" ];

ns.UpdateBoard(options);


string winner = ns.WinnerCheck(options);

Console.WriteLine(winner);