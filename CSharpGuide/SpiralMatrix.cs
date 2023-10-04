using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;
    using System.Collections.Generic;

    class SpiralMatrix
    {
        static void Main26()
        {
            int[][] matrix = {
                new int[] { 1, 2, 3 },
                new int[] { 10, 20, 30 },
                new int[] { 110, 220, 330 },
                new int[] { 1100, 2200, 3300 }
            };

            PrintSpiralMatrix(matrix);
        }


        static void PrintSpiralMatrix(IList<int[]> matrix)
        {
            int totalRows = matrix.Count;
            if (totalRows == 0) return;

            int totalColumns = matrix[0].Length;
            int rowIndex, startRow = 0, startColumn = 0;

            while (startRow < totalRows && startColumn < totalColumns)
            {
                // Print the first row from the remaining rows
                for (rowIndex = startColumn; rowIndex < totalColumns; ++rowIndex)
                {
                    Console.Write($"{matrix[startRow][rowIndex]}\t");
                }
                startRow++;

                // Print the last column from the remaining columns
                for (rowIndex = startRow; rowIndex < totalRows; ++rowIndex)
                {
                    Console.Write($"{matrix[rowIndex][totalColumns - 1]}\t");
                }
                totalColumns--;

                // Print the last row from the remaining rows
                if (startRow < totalRows)
                {
                    for (rowIndex = totalColumns - 1; rowIndex >= startColumn; --rowIndex)
                    {
                        Console.Write($"{matrix[totalRows - 1][rowIndex]}\t");
                    }
                    totalRows--;
                }

                // Print the first column from the remaining columns
                if (startColumn < totalColumns)
                {
                    for (rowIndex = totalRows - 1; rowIndex >= startRow; --rowIndex)
                    {
                        Console.Write($"{matrix[rowIndex][startColumn]}\t");
                    }
                    startColumn++;
                }
            }
        }
    }
}


