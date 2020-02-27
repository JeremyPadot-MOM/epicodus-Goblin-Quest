using System;
using System.Collections.Generic;
using GoblinQuest.Models;

class Program
{
  public static void Main()
  {
    //  Console.WriteLine("Start of game, intro messages to start quest");
    Console.WriteLine("Please enter your Goblin name:");
    string playerName = Console.ReadLine();
    string item = "";
    Quest newQuest = new Quest(playerName, item);
    newQuest.ActOne();
  }
}