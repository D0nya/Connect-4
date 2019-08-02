using System;

namespace CodeWars
{
  class Program
  {
    public static void Main()
    {
      Connect4 c = new Connect4();
      Console.WriteLine(c.play(1));
      Console.WriteLine(c.play(2));
      Console.WriteLine(c.play(2));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(1));
      Console.WriteLine(c.play(1));
      Console.WriteLine(c.play(2));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(3));
      Console.WriteLine(c.play(5));
      Console.WriteLine(c.play(4));
      Console.WriteLine(c.play(5));
      Console.WriteLine(c.play(4));
      Console.WriteLine(c.play(5));
      Console.WriteLine(c.play(4));
      Console.WriteLine(c.play(5));
      Console.WriteLine(c.play(4));
      Console.WriteLine();

      int rows = c.grid.GetUpperBound(0) + 1;
      int columns = c.grid.GetUpperBound(1) + 1;
      for(int i = 0; i < rows; i++)
      {
        for (int j = 0; j < columns; j++)
          Console.Write("{0} ", c.grid[i, j]);
        Console.WriteLine() ;
      }
    }
  }
}