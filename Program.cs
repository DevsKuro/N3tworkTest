using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3tworkTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiral spiral = new Spiral();
            int[] matrixAsArray = { 1, 12, 11, 10, 2, 13, 16, 9, 3, 14, 15, 8, 4, 5, 6, 7 };
            int sideSize = 4;

            spiral.UnrollMatrix(matrixAsArray, sideSize);
        }
    }
}

