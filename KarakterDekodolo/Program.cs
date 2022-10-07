using System.Numerics;

namespace KarakterDekodolo
{
    internal class Program
    {
        static List<Karakter> karakterek = new();
        static char betu = '-'; 
        static void Main()
        {
            KarakterekBeolvasasa();
            Feladat05();
            Feladat06();
            Feladat07();
        }

        private static void Feladat07()
        {
            int i = 0;
            while (i < karakterek.Count && karakterek[i].Betu != betu) i++;
            Console.WriteLine("7. feladat: ");
            if (i < karakterek.Count)
            {
                Console.Write("\n");
                for (int s = 0; s < karakterek[i].Matrix.GetLength(0); s++)
                {
                    for (int o = 0; o < karakterek[i].Matrix.GetLength(1); o++)
                    {
                        if (karakterek[i].Matrix[s, o] == 1)
                            Console.Write("X");
                        else Console.Write(" ");
                    }
                    Console.Write("\n");
                }
            }
            else Console.Write("Nincs ilyen karakter a bankban!");

        }

        private static void Feladat06()
        {
            string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine();

            while (!valid.Contains(betu))
            {
                Console.Write("6. feladat: Kérek egy angol nagybetűt: ");
                string angolNagybetu = Console.ReadLine();
                if (angolNagybetu.Length == 1)
                    betu = char.Parse(angolNagybetu);
            }
        }

        private static void Feladat05()
        {
            Console.WriteLine($"5. feladat: Karakterek szánma: {karakterek.Count}");
        }

        private static void KarakterekBeolvasasa()
        {
            using StreamReader sr = new(@"..\..\..\src\bank.txt");
            while (!sr.EndOfStream)
            {
                char betu = char.Parse(sr.ReadLine());
                int[,] matrix = new int[7, 4];
                for (int s = 0; s < matrix.GetLength(0); s++)
                {
                    string teljesSor = sr.ReadLine();
                    for (int o = 0; o < teljesSor.Length; o++)
                    {
                        matrix[s, o] = int.Parse(teljesSor[o].ToString());
                    }
                }

                karakterek.Add(new Karakter(betu, matrix));
            }
        }
    }
}