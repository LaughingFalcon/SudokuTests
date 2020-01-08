using System;

namespace SudokuMaster
{
    class Program
    {
        static void Main(string[] args)
        {
            Game jogo = new Game();
            int[,] init = jogo.HardGame();
            Sudoku game = new Sudoku(init);

            PrintM(init);

        }


        public static void PrintM(int[,] matrix) 
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                } 
            }
            Console.ReadLine();
        }

       
    }
}
