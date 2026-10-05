using System.Diagnostics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week4.Exercises_Easy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Skapa en konsolapplikation som hanterar ett antal tal i en array.
            //Be användaren ange hur många tal som ska lagras.
            Console.WriteLine("Ange hur många tal som ska lagras");
            //Skapa en int[] med den storleken.
            int UserInputSize = int.Parse(Console.ReadLine()!);
            int[] Tal = new int[UserInputSize];
            //Be användaren mata in varje tal och spara det i arrayen.
            
            for (int i = 0; i < Tal.Length; i++ )
            {
                Console.WriteLine($"Ange tal{i}");
                Tal[i] = int.Parse(Console.ReadLine()!);
            }

            //Skriv ut alla tal som användaren matade in.
            Console.WriteLine("Du har anget:");
        foreach (int tal in Tal)
            {
                Console.WriteLine(tal); //skriver varje element i arrayen
            }

            //(Utmaning)Beräkna och skriv ut summan och medelvärdet av talen.
            int Summa = 0;

            foreach (int nummer in Tal) 
            {
                Summa += nummer; //adderar varje element i arrayen
            }
            Console.WriteLine($"Summan är: {Summa}");
            double median = Summa / Tal.Length; //Detta beräknar medelvärdet
            Console.WriteLine($"Medelvärdet är {median} ");

            //💡 Tips:
            //Använd for-loop för inmatning och utskrift.
            //Använd array.Length för att ta reda på hur många element som finns.
        }
    }
}
