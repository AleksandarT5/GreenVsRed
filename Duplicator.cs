using System;
using System.Collections.Generic;
using System.Text;

namespace GameGreenVsRed
{
    public interface Duplicator
    {
        char[,] duplicate(char[,] playingField, int row, int col);
    }
}
