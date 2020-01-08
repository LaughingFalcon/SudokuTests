using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMaster
{
    public class Sudoku
    {
        public int[,] resp;
        public CellP[,] cell;

        public Sudoku(int[,] init)
        {
            resp = init;
            cell = new CellP[9, 9];
            LoadCellP();

        }

        void LoadCellP()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int[] linha = new int[9];
                    for (int k = 0; k < 9; k++)
                    {
                        if ((k + 1) == resp[i, j])
                        {
                            linha[k] = 1;
                            for (int min = 8; min > k; min--)
                            {
                                linha[min] = 0;
                            }
                            for (int max = 0; max < k; max++)
                            {
                                linha[max] = 0;
                            }
                            k = 9;
                        }
                        else
                        {
                            linha[k] = 1;
                        }
                    }
                    cell[i, j] = new CellP(linha);
                }
                Console.WriteLine();
            }
        }

        void print(int[] linha)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.Write(linha[i] + " ");
                
            }
            Console.WriteLine();
        }

        void verificarQuantPossibilidades(int linha, int coluna)
        {
            if (cell[linha, coluna].quant == 1)
            {
                removerPossibilidadeNumero((linha-1),(coluna),);
            }
        }
        void removerPossibilidadeNumero(int linha, int coluna, int numero)
        {

        }

       
    }
}
