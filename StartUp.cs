using System;
using System.Linq;

namespace GameGreenVsRed
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] gridSizeDimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowNumbers = gridSizeDimensions[1];
            int colNumbers = gridSizeDimensions[0];

            char[,] playingField = new char[rowNumbers,colNumbers];
            for (int row = 0; row < rowNumbers; row++)
            {

                var inputChars = Console.ReadLine().ToCharArray();
                for (int col = 0; col < inputChars.Length; col++)
                {
                    playingField[row, col] = inputChars[col];
                }
                
            }

            int[] coordinatesAndNumberN = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rowTargetCoordinate = coordinatesAndNumberN[1];
            int colTargetCoordinate = coordinatesAndNumberN[0];
            int numberN = coordinatesAndNumberN[2];
                        
            int generationsCount = 0;
            if (playingField[rowTargetCoordinate, colTargetCoordinate] == '1')
            {
                generationsCount++;
            }

            Duplicator duplicator = new FieldDuplicator();
            char[,] duplicateGenerationPlayingField = duplicator.duplicate(playingField, rowNumbers, colNumbers);

            for (int generations = 0; generations < numberN; generations++)
            {
                for (int duplicateRow = 0; duplicateRow <= Math.Min(duplicateRow + 1, playingField.GetLength(0) - 1); duplicateRow++)
                {
                    for (int duplicateCol = 0; duplicateCol <= Math.Min(duplicateCol + 1, playingField.GetLength(1) - 1); duplicateCol++)
                    {

                        PlayingField field = new PlayingField(playingField, duplicateGenerationPlayingField, duplicateRow, duplicateCol);

                        field.generate(playingField, duplicateGenerationPlayingField, duplicateRow, duplicateCol);
                    }
                }

                playingField = duplicator.duplicate(duplicateGenerationPlayingField, rowNumbers, colNumbers);

                if (playingField[rowTargetCoordinate, colTargetCoordinate] == '1')
                {
                    generationsCount++;
                }
            }

            Console.WriteLine(generationsCount);
        }
    }
}
