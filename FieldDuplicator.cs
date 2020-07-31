using System;
using System.Collections.Generic;
using System.Text;

namespace GameGreenVsRed
{
    public class FieldDuplicator : Duplicator
    {
        public char[,] duplicate(char[,] playingField, int row, int col)
        {
            char[,] duplicatedField = new char[row, col];

            for (int i = 0; i < duplicatedField.GetLength(0); i++)
            {
                for (int j = 0; j < duplicatedField.GetLength(1); j++)
                {
                    duplicatedField[i, j] = playingField[i, j];
                }
            }

            return duplicatedField;
        }
    }
}
