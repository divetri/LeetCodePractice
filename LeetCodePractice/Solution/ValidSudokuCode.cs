using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class ValidSudokuCode
    {
        public static void ValidSudoku()
        {
            //help, better way to unit test is needed
            char[][] testCase1 =
            {
                new char[] {'5','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            char[][] testCase2 =
            {
                new char[] {'8','3','.','.','7','.','.','.','.'},
                new char[] {'6','.','.','1','9','5','.','.','.'},
                new char[] {'.','9','8','.','.','.','.','6','.'},
                new char[] {'8','.','.','.','6','.','.','.','3'},
                new char[] {'4','.','.','8','.','3','.','.','1'},
                new char[] {'7','.','.','.','2','.','.','.','6'},
                new char[] {'.','6','.','.','.','.','2','8','.'},
                new char[] {'.','.','.','4','1','9','.','.','5'},
                new char[] {'.','.','.','.','8','.','.','7','9'}
            };

            if (ValidSudoku(testCase1)) Console.WriteLine("True"); else Console.WriteLine("False");
            if (ValidSudoku(testCase2)) Console.WriteLine("True"); else Console.WriteLine("False");
        }
        private static bool ValidSudoku(char[][] board)
        {
            bool isValid = true;
            for (int i = 0; i < 9; i++)
            {
                HashSet<char> horizontal = new HashSet<char>();
                HashSet<char> vertical = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if ((board[i][j] != '.') && !horizontal.Add(board[i][j])) return false;
                    if ((board[j][i] != '.') && !vertical.Add(board[j][i])) return false;
                }
                
            }
            for (int k = 0; k < 9; k++)
            {
                HashSet<char> box = new HashSet<char>();
                int boxRow = k / 3 * 3;
                int boxCol = k % 3 * 3;
                for (int i = boxRow; i < boxRow + 3; i++)
                {
                    for (int j = boxCol; j < boxCol + 3; j++)
                    {
                        if (board[i][j] != '.' && !box.Add(board[i][j])) return false;
                    }
                }
            }
            return isValid;
        }
    }
}
