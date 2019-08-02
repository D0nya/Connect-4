namespace CodeWars
{
  class Player
  {
    private int number;
    public Player()
    {
      Name = "NoName";
    }
    public Player(string name, int num)
    {
      Name = name;
      Number = num;
    }
    public string Name { get; set; }
    public int Number
    { get { return number; }
      set
      { if (value == 0)
          number = -1;
        else
          number = value;
      }
    }
  }
}