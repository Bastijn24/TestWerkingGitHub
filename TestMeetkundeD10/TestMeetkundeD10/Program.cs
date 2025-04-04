using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeetkundeDeel10;

namespace TestMeetkundeD10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Van welk ruimtefiguur wil je het volume berekenen? ");
            Console.WriteLine("1. Balk");
            Console.WriteLine("2. Cilinder");
            Console.WriteLine("3. Prisma");
            Console.WriteLine();
            Console.Write("Mijn keuze: ");

            int keuze = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (keuze == 1)
            {
                Balk balk = new Balk();
                Console.WriteLine("Wat is de breedte van het grondvlak? ");
                Console.Write("Breedte: ");
                balk.Breedte = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de lengte van het grondvlak? ");
                Console.Write("Lengte: ");
                balk.Lengte = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de hoogte van de balk? ");
                Console.Write("Hoogte balk: ");
                balk.HoogteBalk = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Het volume van de balk is {0}", balk.BerekenVolumeBalk());
                Console.ReadKey();
            }

            if (keuze == 2)
            {
                Cilinder cilinder = new Cilinder();
                Console.WriteLine("Wat is de straal van het grondvlak? ");
                Console.Write("Straal: ");
                cilinder.Straal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de hoogte van de cilinder? ");
                Console.Write("Hoogte cilinder: ");
                cilinder.HoogteCilinder = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Het volume van de cilinder is {0}", cilinder.BerekenVolumeCilinder());
                Console.ReadKey();
            }

            if (keuze == 3)
            {
                Prisma prisma = new Prisma();
                Console.WriteLine("Wat is de lengte van de basiszijde? ");
                Console.Write("Lengte basiszijde: ");
                prisma.Z1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de lengte van de tweede zijde? ");
                Console.Write("lengte tweede zijde: ");
                prisma.Z2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de lengte van de derde zijde? ");
                Console.Write("lengte derde zijde: ");
                prisma.Z3 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de hoogte op de basiszijde? ");
                Console.Write("hoogte op basiszijde: ");
                prisma.H = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Wat is de hoogte van de prisma? ");
                Console.Write("hoogte prisma: ");
                prisma.HoogtePrisma = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Het volume van de prisma is {0}", prisma.BerekenVolumePrisma());
                Console.ReadKey();
            }

        }
    }
}
