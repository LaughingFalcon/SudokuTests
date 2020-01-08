using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMaster.Models
{
    public class Cell : ICellModel
    {
        ICellModel Down;
        ICellModel Up;
        ICellModel Left;
        ICellModel Right;

        public Cell()
        {
            Down = new CellNull();
            Up = new CellNull();
            Left = new CellNull();
            Right = new CellNull();
        }

        public ICellModel Downward()
        {
            return Down;
        }

        public ICellModel ToTheLeft()
        {
            return Left;
        }

        public ICellModel ToTheRight()
        {
            return Right;
        }

        public ICellModel Upward()
        {
            return Up;
        }
    }
}
