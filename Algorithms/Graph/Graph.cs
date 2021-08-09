using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Graph
{
    public class Graph
    {
        public int V { get; init; }
        public LinkedList<int>[] Adj { get; }

        public Graph(int v)
        {
            this.V = v;
            this.Adj = new LinkedList<int>[v];
            for (int i = 0; i < this.V; i++)
            {
                this.Adj[i] = new LinkedList<int>();
            }
        }

        public void AddEdge(int v, int w)
        {
            this.Adj[v].AddLast(w);
        }

        /*
         * Given a matrix:   
         *                   
         *                   0 1 0 0 1
         *                   1 0 1 1 1
         *                   0 0 0 1 1
         *                   0 1 0 1 0
         *                   1 0 0 0 0
         *                   
         * Convert it to a graph: 
         *  + Consider each cell is a node and each boundary is an edge
         */
        public static Graph ConvertFromMatrix(int[][] matrix)
        {
            int k = 0;
            int n = matrix.Length;
            int m = matrix[0].Length;

            Graph graph = new Graph(n * m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == n - 1)
                    {
                        if (j != m - 1)
                        {
                            graph.AddEdge(k, k + 1);
                            graph.AddEdge(k + 1, k);
                        }
                    }
                    else if (j == m - 1)
                    {
                        graph.AddEdge(k, k + m);
                        graph.AddEdge(k + m, k);
                    }
                    else
                    {
                        graph.AddEdge(k, k + 1);
                        graph.AddEdge(k, k + m);
                    }

                    k++;
                }
            }

            return graph;
        }
    }
}
