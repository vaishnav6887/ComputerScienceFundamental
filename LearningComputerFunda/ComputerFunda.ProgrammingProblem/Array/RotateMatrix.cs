using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFunda.ProgrammingProblem.Array
{
    /// <summary>
    /// Methods to rotate the matrix by specific degrees.
    /// </summary>
    public class RotateMatrix
    {
        private int[,] _matrix;
        private readonly int _length;
        private readonly int levels;

        public int[,] Matrix
        {
            get
            {
                return _matrix;
            }
        }

        public RotateMatrix(int[,] matrix, int length)
        {
            _matrix = matrix;
            _length = length;
            levels = _length % 2 == 0 ? _length / 2 : (_length - 1) / 2;
        }

        public void RotateMatrixBy90DegreeAntiClockWise()
        {
            for (int i = 0; i < levels; i++)
            {
                for (int j = i; j < (_length - i - 1); j++)
                {
                    int swap = _matrix[i, j];
                    _matrix[i, j] = _matrix[j, _length - i - 1];
                    _matrix[j, _length - i - 1] = _matrix[_length - i - 1, _length - j - 1];
                    _matrix[_length - i - 1, _length - j - 1] = _matrix[_length - i - 1, j];
                    _matrix[_length - i - 1, j] = swap;
                }
            }
        }

        public void RotateMatrixBy180DegreeAnticlockWise()
        {
            for (int i = 0; i < levels; i++)
            {
                for (int j = i; j < (_length - i - 1); j++)
                {
                    int swap = _matrix[i, j];
                    _matrix[i, j] = _matrix[_length - i - 1, _length - j - 1];
                    _matrix[_length - i - 1, _length - j - 1] = swap;

                    swap = _matrix[j, _length - i - 1];
                    _matrix[j, _length - i - 1] = _matrix[_length - j - 1, i];
                    _matrix[_length - j - 1, i] = swap;
                }
            }
        }
    }
}
