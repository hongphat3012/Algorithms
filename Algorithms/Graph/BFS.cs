using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph
{
    public class BFS
    {
        public void Execute(int[][] matrix)
        {
            Graph graph = Graph.ConvertFromMatrix(matrix);

            int n = matrix.Length;
            int m = matrix[0].Length;

            bool[] visited = new bool[n * m];
            for (int i = 0; i < n * m; i++)
            {
                visited[i] = false;
            }

            LinkedList<int> queue = new LinkedList<int>();

            queue.AddLast(0);

            while(queue.Any())
            {
                int v = queue.First();
                Console.Write(v + " ");
                queue.RemoveFirst();

                LinkedList<int> adjs = graph.Adj[v];
                foreach(var adj in adjs)
                {
                    if(visited[adj] == false)
                    {
                        visited[adj] = true;
                        queue.AddLast(adj);
                    }
                }
            }

        }
    }
}
