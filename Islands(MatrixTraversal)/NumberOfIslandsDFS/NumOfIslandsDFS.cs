using System;

//Matrix Traversal
//Find number of islands using DFS


class NumOfIslandsDFS {
    
    public static int countIslands(int[,] matrix) 
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int totalIslands = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (matrix[i,j] == 1) { // only if the cell is a land
                // we have found an island
                totalIslands++;
                visitIslandDFS(matrix, i, j);
                }
            }
        }
        return totalIslands;
    }
  
    private static void visitIslandDFS(int[,] matrix, int x, int y) 
    {
        if (x < 0 || x >= matrix.GetLength(0) || y < 0 || y >= matrix.GetLength(1))
        return; // return, if it is not a valid cell
        if (matrix[x,y] == 0)
        return; // return, if it is a water cell

        matrix[x,y] = 0; // mark the cell visited by making it a water cell

        // recursively visit all neighboring cells (horizontally & vertically)
        visitIslandDFS(matrix, x + 1, y); // lower cell
        visitIslandDFS(matrix, x - 1, y); // upper cell
        visitIslandDFS(matrix, x, y + 1); // right cell
        visitIslandDFS(matrix, x, y - 1); // left cell
    }
       
        
    static void Main(String[] args) {               
        int[,] TwoDimensionalArray = new int[,] {
                    { 0, 1, 1, 1, 0 },
                    { 0, 0, 0, 1, 1 },
                    { 0, 1, 1, 1, 0 },
                    { 0, 1, 1, 0, 0 },
                    { 0, 0, 0, 0, 0 }
                };
                        
        Console.WriteLine("Number of Islands (easy) ");   
        Console.WriteLine(countIslands(TwoDimensionalArray));
    }
}


