using System;

class Program {

  static decimal Unos()
        {
            decimal unesenibroj;
            Console.WriteLine("Unesite koliko para zelite da uplatite");
            while (!decimal.TryParse(Console.ReadLine(), out unesenibroj) || unesenibroj <= 0 )
            {
                Console.WriteLine("Cifra koju zelite da uplatite nije ispravno unet,unesite ponovo");
            }
            return unesenibroj;
        }
  
  public static ulong Model97()
  {
  ulong PozivNaBroj,PNB2Nule,KontrolniBroj;
          Console.WriteLine("Unesi poziv na broj:");
           PozivNaBroj=ulong.Parse(Console.ReadLine());
          PNB2Nule=ulong.Parse(Convert.ToString(PozivNaBroj)+"00");
        KontrolniBroj=98-PNB2Nule%97;
          
          return KontrolniBroj;
  } 
  
  public static void Main (string[] args) 
  {
        Console.ForegroundColor=ConsoleColor.Cyan;
    Console.WriteLine ("Hello world");
  }
}