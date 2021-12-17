using System;

namespace HW4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };
            Dijkstra dijk = new Dijkstra();
            dijk.Algo(graph, 0);
        }
    }

    public class Dijkstra
    {
        
        static int NumOfVertices = 9;

        int Distance(int[] dist, bool[] sptSet)
        {
             
            int min = int.MaxValue, min_index = -1;
            for (int v = 0; v < NumOfVertices; v++)
            {
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            }
            return min_index;
        }

        
        void Print(int[] dist, int n, int srcVert)
        {
            Console.Write("Vertex Distance from Source {0}\n", srcVert);
            for (int i = 0; i < NumOfVertices; i++)
            {
                Console.Write(i + " \t\t " + dist[i] + "\n");
            }
        }

         
        public void Algo(int[,] graph, int srcVert)
        {
            int[] dist = new int[NumOfVertices];
            
            bool[] sptSet = new bool[NumOfVertices];

            
            for (int i = 0; i < NumOfVertices; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }
 
           
            dist[srcVert] = 0;
           
            for (int count = 0; count < NumOfVertices - 1; count++)
            {
               
                int minDistance = Distance(dist, sptSet);
               
                sptSet[minDistance] = true;
                
                for (int indx = 0; indx < NumOfVertices; indx++)
                {
                    
                    if (!sptSet[indx] && graph[minDistance, indx] != 0 && dist[minDistance] != int.MaxValue && dist[minDistance] + graph[minDistance, indx] < dist[indx])
                    {
                        dist[indx] = dist[minDistance] + graph[minDistance, indx];
                    }
                }
            }
            
            Print(dist, NumOfVertices, srcVert);
        }
    }
}
