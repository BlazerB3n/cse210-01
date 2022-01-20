//Tik tac toe project 1
using System;

namespace cse210_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] board = createboard();
            string player = NextPlayer("");
            while (!IsFinished(board) && !HasWinner(board))
            {
            displayboard(board);
            MakeMove(player, board);
            player = NextPlayer(player);
            }
            displayboard(board);
            Console.Write("Good game");


            static string[] createboard()
            {
                string[] board = new string[9];
            for (int i = 0; i < 9; i++)
            {
                board[i] = (i + 1).ToString();
            }
            return board;
            }

            static void displayboard(string [] board)
            {
            Console.WriteLine();
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
            Console.WriteLine();
            }
        
            static void MakeMove(string player, string[] board)
        {
            Console.Write($"\n{player}'s turn to choose a square (1-9): ");
            int square = Convert.ToInt32(Console.ReadLine());
            board[square - 1] = player;
        }

        static bool HasWinner(string[] board)
        {
            return ((board[0] == "x" && board[1] == "x" && board[2] == "x") 
                    || (board[3] == "x" && board[4] == "x" && board[5] == "x") 
                    || (board[6] == "x" && board[7] == "x" && board[8] == "x") 
                    || (board[0] == "x" && board[3] == "x" && board[6] == "x") 
                    || (board[1] == "x" && board[4] == "x" && board[7] == "x") 
                    || (board[2] == "x" && board[5] == "x" && board[8] == "x") 
                    || (board[0] == "x" && board[4] == "x" && board[8] == "x")
                    || (board[2] == "x" && board[4] == "x" && board[6] == "x"));
        }

        static bool IsFinished(string[] board)
        {
            bool result = true;
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != "x" && board[i] != "o")
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        static string NextPlayer(string current)
        {
            string player = "o";
            if (current == "" || current == "o")
            {
                player = "x";
            }
            return player;
            }
        }
    }
}

