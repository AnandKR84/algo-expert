using System;

namespace AlgoExpert
{
    public class Solution
    {
        public static int IslandPerimeter(int[][] grid)
        {
            int perimeter = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == 1)
                    {
                        if(i==0)
                        {
                            ++perimeter;
                        }
                        else
                        {
                            if (grid[i - 1][j] == 0)
                            {
                                ++perimeter;
                            }                            
                        }

                        if(j==0)
                        {
                            ++perimeter;
                        }
                        else
                        {
                            if(grid[i][j-1]==0)
                            {
                                ++perimeter;
                            }
                        }

                        if(i == grid.Length-1)
                        {
                            ++perimeter;
                        }
                        else
                        {
                            if(grid[i+1][j] == 0)
                            {
                                ++perimeter;
                            }
                        }
                        if (j == grid[i].Length - 1)
                        {
                            ++perimeter;
                        }
                        else
                        {
                            if(grid[i][j+1] ==0)
                            {
                                ++perimeter;
                            }
                        }
                    }
                }
            }
            return perimeter;
        }
    }
}
