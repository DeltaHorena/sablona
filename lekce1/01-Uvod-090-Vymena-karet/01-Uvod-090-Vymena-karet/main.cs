using System;

class MainClass {
    public static void Main (string[] args) {
          
        string Pavel = "Červená sedma";
        string Petr = "Kulový spodek";
      string stul = "";
        
        // Sem přijde váš kód, je zakázáno použít uvozovky
    stul = Petr;
      Petr = Pavel;
      Pavel = stul;
    
    
    
        // Konec prostoru pro kód
        
        Console.WriteLine("Pavel má v ruce: " + Pavel); //mělo by vypsat "Kulový spodek"
        Console.WriteLine("Petr má v ruce: " + Petr);  //mělo by vypsat "Červená sedma"
    }
}