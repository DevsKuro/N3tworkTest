using System;
using System.Collections.Generic;

namespace N3tworkTest
{
    public interface ISpiral
    {
        int[] UnrollMatrix(int[] matrixAsArray, int sideSize);
        
    }

    public class Spiral : ISpiral
    { 
        public int[] UnrollMatrix(int[] matrixAsArray, int sideSize)
        {
            int[] newMatrixArray = new int[matrixAsArray.Length];
            int[,] matrix = new int[sideSize, sideSize];

            int startingRowIndex = 0;
            int finalRowIndex = sideSize - 1;
            int startingColumnIndex = 0;
            int finalColumnIndex = sideSize - 1;
            int count = 0;

            //Transform array into a matrix
            for (int i = 0; i < sideSize; i++)
            {
                for (int j = 0; j < sideSize; j++)
                {
                    matrix[i, j] = matrixAsArray[count];
                    count += 1;
                }
            }

            int step = sideSize - 1;
            //Assign new array
            for (int i = 0; i < matrixAsArray.Length; i++)
            {
                //the main focus is going through the matrix
                //starting with column target 0 and the assign column target to last -1
                //after finishing column 0 start moving to the initialRow (sidesize -1)
                //and doing the reverse to the column
                //when initialcolumn and finalcolumn are equals, the path end
            }

            return newMatrixArray;
        }
    }
}
