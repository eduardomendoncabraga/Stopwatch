﻿using System;

namespace Stopwatch
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    static void Start()
    {
      int time = 10;
      int currentTime = 0;

      while (currentTime != time)
      {
        currentTime++;
      }
    }
  }
}
