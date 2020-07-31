using System;
using System.Collections.Generic;
using System.Text;

namespace GameGreenVsRed
{
    public interface Field
    {
        void generate(char[,] playingField, char[,] duplicateField, int row, int col);
    }
}
