using System;
using System.Collections.Generic;

public class Triangle
{
  public int SideOne;
  public int SideTwo;
  public int SideThree;

  public Triangle(int sideOne, int sideTwo, int sideThree)
  {
    SideOne = sideOne;
    SideTwo = sideTwo;
    SideThree = sideThree;
  }

  public string TriangleType()
  {
    if (SideOne == SideTwo && SideTwo == SideThree)
    {
      return "equilateral";
    }
    else if (SideOne == SideTwo || SideTwo == SideThree || SideThree == SideOne)
    {
      return "isosceles";
    }
    else
    {
      return "scalene";
    }
  }

  public bool IsATriangle()
  {
    if (SideOne + SideTwo > SideThree && SideTwo + SideThree > SideOne && SideThree + SideOne > SideTwo)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
}

public class Program
{
    public static void Main()
    {
      Console.WriteLine("Input a number for side one:");
      string stringSideOne = Console.ReadLine();
      int intSideOne = int.Parse(stringSideOne);

      Console.WriteLine("Input a number for side two:");
      string stringSideTwo = Console.ReadLine();
      int intSideTwo = int.Parse(stringSideTwo);

      Console.WriteLine("Input a number for side three:");
      string stringSideThree = Console.ReadLine();
      int intSideThree = int.Parse(stringSideThree);

      Triangle userTriangle = new Triangle(intSideOne, intSideTwo, intSideThree);

      if (userTriangle.IsATriangle())
      {
        Console.WriteLine(userTriangle.TriangleType());
      }
      else
      {
        Console.WriteLine("This is not triangle, please try again.");
      }
    }
}