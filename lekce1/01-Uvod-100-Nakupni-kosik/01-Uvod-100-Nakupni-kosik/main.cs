using System;

class MainClass {
    public static void Main (string[] args) {

        string zbozi1 = "Vejce";
        double cena1 = 3.5;
        
        string zbozi2 = "Rohlík";
        double cena2 = 1.9;
        
        string zbozi3 = "Chleba";
        double cena3 = 25;  

      double celkovaCena = 0;
      int pocet = 0;
        // Sem přijde váš kód
        Console.WriteLine(zbozi1 + " stoji " + cena1 + "(Kč)" + "Kolik kusu chcete? ");
      pocet = int.Parse(Console.ReadLine());
      celkovaCena = celkovaCena + pocet*cena1;

          Console.WriteLine(zbozi2 + " stoji " + cena2 + "(Kč)" + "Kolik kusu chcete? ");
      pocet = int.Parse(Console.ReadLine());
      celkovaCena = celkovaCena + pocet*cena2;

          Console.WriteLine(zbozi3 + " stoji " + cena3 + "(Kč)" + "Kolik kusu chcete? ");
      pocet = int.Parse(Console.ReadLine());
      celkovaCena = celkovaCena + pocet*cena3;

      Console.WriteLine("Celkova cena nakupu je: " + celkovaCena);
        
        
        // Konec prostoru pro kód
    }
}