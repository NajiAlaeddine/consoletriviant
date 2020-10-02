using System;

namespace ConsoleTriviant
{
    class Program
    {
        static int score = 0; // aantal vragen goed
        static string Vraag = "waarmee proeven vlinders"; //vraag
        static string[] Antwoorden = { "Poten", "Neus", "Tong", "Oren" }; // aray
        static int JuisteAntwoord = 1; //index in array antwoorden van het juiste antwoord
        static void Main(string[] args) 
        {
            Console.WriteLine("Welkom bij triviant");
            Console.WriteLine("Je ziet een vraag op het scherm");
            Console.WriteLine("Je ziet vier antwoorden");
            Console.WriteLine("Kies het juiste antwoord en je krijgt gelijk " + " het resultaat. Zullen we beginnen geef dan een Enter.");
            Console.ReadLine();
            showVraag(1);
            showAntwoorden();

            try
            {
                int Poten = int.Parse(Console.ReadLine());
                switch (checkAntwoord(Poten)) 
                {
                    case 1:
                        Console.WriteLine("Goed gedaan.");
                        score++;
                        break;
                    case 0:
                        Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + Antwoorden[JuisteAntwoord]);
                        break;
                    case 99:
                        Console.WriteLine("Dit is geen geldige invoer.");
                        break;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message); 
            }
        }
        static void showVraag(int Nr)
        {
            Console.WriteLine("Vraag " + Nr + ":");
            Console.WriteLine(Vraag); 
            Console.WriteLine("");
        }
        static void showAntwoorden()
        {
            int teller = 0;
            foreach (string antwoorden in Antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ".  + antwoorden");
            }
            Console.WriteLine("");
            Console.WriteLine("Type uw keuze : 1,2,3 of 4");
        }
        static int checkAntwoord(int Poten, int Nr)
        {
            if (Poten == JuisteAntwoord + 1)
            {
                return 1;
            }
            else if (Poten > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }
       

    }
}
        
