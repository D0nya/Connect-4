using System.Collections.Generic;

namespace CodeWars
{
  class Connect4
  {
    public readonly Queue<Player> pQueue;
    public readonly int[,] grid;
    private bool gameOver = false;
    public Connect4()
    {
      pQueue = new Queue<Player>();
      pQueue.Enqueue(new Player("Player 1", 1));
      pQueue.Enqueue(new Player("Player 2", 2));
      grid = new int[6, 7];
    }
    public string play(int col)
    {
      if (gameOver)
        return "Game has finished!";
      Player currentPlayer = pQueue.Peek();

      for(int row = grid.GetUpperBound(0); row >= 0; row--)
      {
        if (grid[row, col] == 0)
        {
          grid[row, col] = currentPlayer.Number;
          pQueue.Enqueue(pQueue.Dequeue());
          if (CountFour(currentPlayer.Number) != 0)
          {
            gameOver = true;
            return currentPlayer.Name + "wins";
          }
          return string.Format(currentPlayer.Name + "has a turn");
        }
      }
      return "Column full!";
    }
    private int CountFour(int num)
    {
      int rows = grid.GetUpperBound(0) + 1;
      int columns = grid.GetUpperBound(1) + 1;
      int i , j;
      for (i = 0; i < rows; i++)
      {
        for (j = 0; j < columns - 3; j++)
        {
          if (num == grid[i, j] &&
              num == grid[i, j + 1] &&
              num == grid[i, j + 2] &&
              num == grid[i, j + 3])
            return num;
        }
      }
      for(i = 0; i < rows - 3; i++)
      {
        for (j = 0; j < columns; j++)
        {
          if (num == grid[i, j] &&
              num == grid[i + 1, j] &&
              num == grid[i + 2, j] &&
              num == grid[i + 3, j])
            return num;
        }
      }

      for(i = 0; i < rows - 3; i++)
      {
        for(j = 3; j < columns; j++)
        {
          if (num == grid[i,j]&&
              num == grid[i + 1, j - 1] &&
              num == grid[i + 2, j - 2] &&
              num == grid[i + 3, j - 3])
            return num;
        }
      }
      for (i = 0; i < rows - 3; i++)
      {
        for (j = 0; j < columns - 3; j++)
        {
          if (num == grid[i, j] &&
              num == grid[i + 1, j + 1] &&
              num == grid[i + 2, j + 2] &&
              num == grid[i + 3, j + 3])
            return num;
        }
      }
      return 0;
    }
  }
}