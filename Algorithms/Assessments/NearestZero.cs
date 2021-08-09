using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Assessments
{
    public class NearestZero
    {
        public int[][] Execute(int[][] matrix)
        {
            var directions = new (int, int)[] { (-1, 0), (1, 0), (0, -1), (0, 1) };

            int n = matrix.Length;
            int m = matrix[0].Length;
            bool[][] visited = new bool[n][];

            LinkedList<int[]> queue = new LinkedList<int[]>();
            for (int i = 0; i < n; i++)
            {
                visited[i] = new bool[m];
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        queue.AddLast(new int[] { i, j });
                        visited[i][j] = true;
                    }
                    else
                    {
                        matrix[i][j] = int.MaxValue;
                        visited[i][j] = false;
                    }
                }
            }

            while (queue.Any())
            {
                int[] q = queue.First();
                queue.RemoveFirst();

                foreach (var (di, dj) in directions)
                {
                    int ni = q[0] + di, nj = q[1] + dj;

                    if (ni >= 0 && ni < n && nj >= 0 && nj < m)
                    {
                        if (visited[ni][nj] == true)
                        {
                            continue;
                        }

                        matrix[ni][nj] = Math.Min(matrix[ni][nj], matrix[q[0]][q[1]] + 1);
                        queue.AddLast(new int[] { ni, nj });
                        visited[ni][nj] = true;
                    }
                }
            }

            return matrix;
        }
    }
}
