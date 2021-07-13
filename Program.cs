using System;
using System.Collections.Generic;
namespace login
{
  class Program
  {
    static void Main(string[] args)
    {
      var users = new Dictionary<string, string>();
      users.Add("test3", "Testing!123"); //adding a key/value using the Add() method
      bool run = true;
      while (run)
      {

        System.Console.WriteLine("login or sign up");
        string input = Console.ReadLine().ToLower();
        if (input == "q")
        {
          run = false;
          break;
        }
        if (input == "sign up")
        {
          System.Console.WriteLine("create username");
          string username = System.Console.ReadLine();
          System.Console.WriteLine("create password");
          string password = System.Console.ReadLine();
          users.Add(username, password);
          System.Console.WriteLine("account created");
        }
        else if (input == "login")
        {
          System.Console.WriteLine("username");
          string username = System.Console.ReadLine();
          if (users.ContainsKey(username))
          {
            System.Console.WriteLine("password");
            string password = System.Console.ReadLine();
            if (users.ContainsValue(password))
            {
              System.Console.WriteLine($"welcome {username}");
              song();
            }
            else
            {
              System.Console.WriteLine("invalid password");
            }
          }
          else
          {
            System.Console.WriteLine("invalid username");
          }
        }
        else
        {
          System.Console.WriteLine($"cannot compute {input}");
        }
      }
    }
    static void song()
    {
      Console.Beep(440, 500);
      Console.Beep(440, 500);
      Console.Beep(440, 500);
      Console.Beep(349, 350);
      Console.Beep(523, 150);
      Console.Beep(440, 500);
      Console.Beep(349, 350);
      Console.Beep(523, 150);
      Console.Beep(440, 1000);
      Console.Beep(659, 500);
      Console.Beep(659, 500);
      Console.Beep(659, 500);
      Console.Beep(698, 350);
      Console.Beep(523, 150);
      Console.Beep(415, 500);
      Console.Beep(349, 350);
      Console.Beep(523, 150);
      Console.Beep(440, 1000);
    }
  }
}
