using System;

namespace TriangleDrawer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Üçgenin boyutunu girin (pozitif bir tamsayı): ");
            int size;
            if (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Geçerli bir boyut girin.");
                return;
            }

            TriangleDrawer.Draw(size);

            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
            Console.ReadKey();
        }
    }

    public static class TriangleDrawer
    {
        public static void Draw(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 0; j < size - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
