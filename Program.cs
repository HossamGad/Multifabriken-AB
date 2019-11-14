using System;

using System.Collections.Generic;



namespace Multifabriken

{



    class Program

    {

        static void Main(string[] args)  //Metod: main start på programmet

        {
                         //-----------produktlistor----------//
            var _Bilar = new List<string>();
            var _Godis = new List<string>();
            var _Ror = new List<string>();
            var _Havre = new List<string>();

            int _val = 0;
			int.TryParse(Console.ReadLine(), out _val);
            while(_val != 6)

            {

                Console.Clear();

                Console.WriteLine();
                                       //-------------------Menu-----------------------//
                Console.Write("\tVälkommen till Multifabriken AB!\n");
                Console.WriteLine("\t  Välj mellan produkter:");
                Console.WriteLine("\t   [1] Bilar ");
                Console.WriteLine("\t   [2] Godis ");
                Console.WriteLine("\t   [3] Rör ");
                Console.WriteLine("\t   [4] Havremjölk ");
                Console.WriteLine("\t   [5] Skriv ut alla produkter ");
                Console.WriteLine("\t   [6] Avsluta programmet ");
                Console.Write("\n\t         Välj: ");
                Console.WriteLine();


                int val = 0;
				int.TryParse(Console.ReadLine(), out val); //Här hanterar jag felet

                switch(val)

                {

                    case 1:

                        Bilar Bilar = new Bilar();

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Bil info: ");

                        Console.Write("Skriv in registreringsnummer: ");

                        Bilar.registreringsnummer = Console.ReadLine();

                        Console.Write("Skriv in färg: ");

                        Bilar.färg = Console.ReadLine();

                        Console.Write("Skriv in märke: ");

                        Bilar.märke = Console.ReadLine();


                                  //Här kommer info på skärmen
                        string strBilar = $"Den är {Bilar.färg} och har registreringsnummer {Bilar.registreringsnummer}, märket är : {Bilar.märke}";

                        
                        _Bilar.Add(strBilar);// Här sparas info i listan

                        break;

                    case 2:

                        Godis Godis = new Godis();



                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine("Beställ godis: ");

                        Console.Write("Skriv in smak: ");

                        Godis.smak = Console.ReadLine();

                        Console.Write("Skriv in antal: ");

                        Godis.antal = Console.ReadLine();

                        
                                        //Här kommer info på skärmen
                        string strGodis = $"Smak: {Godis.smak} och du har beställt: {Godis.antal} kg";



                        _Godis.Add(strGodis);// Här sparas info i listan

                        break;

                    case 3:

                        rör Ror = new rör();



                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine("Beställ rör: ");

                        Console.Write("Skriv in diameter: ");

                        Ror.diameter = Console.ReadLine();

                        Console.Write("Skriv in längd: ");

                        Ror.längd = Console.ReadLine();


                                              //Här kommer info på skärmen
                        string strRor = $"Diameter: {Ror.diameter} cm och längden är: {Ror.längd} cm";



                        _Ror.Add(strRor);// Här sparas info i listan

                        break;

                    case 4:

                        havremjolk Havremjolk = new havremjolk();



                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine("Beställ havremjölk: ");

                        Console.Write("Fetthalt? ");

                        Havremjolk.fetthalt = Console.ReadLine();

                        Console.Write("Hur många liter? ");

                        Havremjolk.liter_mängd = Console.ReadLine();

                                           //Här kommer info på skärmen
                        string strHavre = $"{Havremjolk.liter_mängd} liter mjölk med {Havremjolk.fetthalt} % Fetthalt";

                        _Havre.Add(strHavre);// Här sparas info i listan

                        break;

                    case 5:

                        Console.Clear();

                        Console.WriteLine();

                        Console.WriteLine("Här kommer en lista på alla beställda varor:\n ({0} Bilar, {1} Godisar, {2} Rör, {3} Havremjölk): ", _Bilar.Count, _Godis.Count, _Ror.Count, _Havre.Count);

                        Console.WriteLine();



                        int countBil = 0;

                        foreach (string bil in _Bilar)//Här loopar progammet för att hämta värdet från listan

                        {

                            countBil++;

                            Console.WriteLine("Bil {0}: {1}", countBil, bil);

                        }

                        int countGodis = 0;

                        foreach (string godis in _Godis)//Här loopar progammet för att hämta värdet från listan

                        {

                            countGodis++;

                            Console.WriteLine("Godis {0}: {1}", countGodis, godis);

                        }

                        int countRor = 0;

                        foreach (string ror in _Ror)//Här loopar progammet för att hämta värdet från listan

                        {

                            countRor++;

                            Console.WriteLine("Rör {0}: {1}", countRor, ror);

                        }

                        int countHavre = 0;

                        foreach (string havre in _Havre)//Här loopar progammet för att hämta värdet från listan

                        {

                            countHavre++;

                            Console.WriteLine("Havremjölk {0}: {1}", countHavre, havre);

                        }

                       

                        Console.WriteLine();

                        Console.WriteLine("\nTryck på valfri tangent för att återgå till huvudmenyn..");
                        Console.ReadKey();
                        

                        
                        break;
                    case 6:

                        Console.Clear();

                        Console.WriteLine("Programmet avslutas.."); 
                        Console.ReadKey();
                        Console.Clear();
                        return;
                        
                    default:

                        Console.WriteLine();

                        Console.WriteLine("\n\tFel inmatning, Välj mellan 1-6 från menyn!\n");//Här hanterar jag felet.
                        Console.ReadKey();
                        break;

                }

            }

        }

    }

}