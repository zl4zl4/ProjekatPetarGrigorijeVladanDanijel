using System;

class Program {
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