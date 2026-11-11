
using MatesLab;

namespace MatesConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entra un numero de 1 A 9:");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num<1 || num > 9)
            {
                Console.WriteLine("El numero que has entrat no es correcte");
                Console.Write("Entra un numero de 1 A 9");
                num = Convert.ToInt32(Console.ReadLine());


            }

            Mates.TaulaMultiplicar(num);


        }
    }
}
