using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuMaster.Models
{
    public interface ICellModel
    {
        ICellModel ToTheLeft();
        ICellModel ToTheRight();
        ICellModel Upward();
        ICellModel Downward();
    }
}
