using System;

class MainClass {
  public static void Main (string[] args) {
   Random generator = new Random();
    int strana = generator.Next(1,7);
    Console.WriteLine("Na kostce padlo cislo " + strana);
    
  }
}