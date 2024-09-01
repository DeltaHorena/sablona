using System;


class MainClass {
  public static void Main (string[] args) {
   Random generator = new Random();
    Console.WriteLine("Zadej pocet sten kostky:");
    int pocet = int.Parse(Console.ReadLine());
    Console.WriteLine("Hod jedna");
    int prvni = generator.Next(1,pocet+1);
    Console.WriteLine("Hod dva");
    int druhy = generator.Next(1,pocet+1);
    Console.WriteLine("Hod tri");
    int treti = generator.Next(1,pocet+1);
    Console.WriteLine("Hozena cisla:");
    Console.WriteLine("Hod jedna: " + prvni);
    Console.WriteLine("Hod dva: " + druhy);
    Console.WriteLine("Hod tri: " + treti);

    double prumerHod = (prvni+druhy+treti)/3.0;
    Console.WriteLine("Prumer z hodu je " + prumerHod);
  }
}