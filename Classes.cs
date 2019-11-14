using System;

using System.Collections.Generic;



namespace Multifabriken

{

    public class produkter  //Basklass

    {

              //Class egenskaper

    }



    public class Bilar  : produkter   //Underklass(Här ärver vi klassfakta från basklass bok)

    {

        public string registreringsnummer;  //Class egenskaper

        public string färg;

        public string märke;

    }



    class Godis : produkter  //Underklass(Här ärver vi klassfakta från basklass bok)

    {

        public string smak;  //Class egenskaper

        public string antal;

    }



    class rör : produkter  //Underklass(Här ärver vi klassfakta från basklass bok)

    {

        public string diameter;  //Class egenskaper

        public string längd;

    }



    class havremjolk : produkter   //Underklass(Här ärver vi klassfakta från basklass bok)

    {

        public string fetthalt;  //Class egenskaper

        public string liter_mängd;

    }

}
