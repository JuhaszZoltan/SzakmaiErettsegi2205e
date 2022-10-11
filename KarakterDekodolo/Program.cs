namespace KarakterDekodolo
{
    //https://www.github.com/JuhaszZoltan

    internal class Program
    {
        static char betu = '-'; 
        static List<Karakter> dekodol;
        static List<Karakter> karakterBank;
        static void Main()
        {
            Feladat04();
            Feladat05();
            Feladat06();
            Feladat07();
            Feladat08();
            Feladat09();
        }
        private static List<Karakter> Beolvas(string file)
        {
            List<Karakter> karakterLista = new();
            using StreamReader sr = new(file);
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
                karakterLista.Add(new Karakter(betu, matrix));
            }
            return karakterLista;
        }
        private static void Feladat04()
            => karakterBank = Beolvas(@"..\..\..\src\bank.txt");
        private static void Feladat05()
            => Console.WriteLine($"5. feladat: Karakterek szánma: {karakterBank.Count}");
        private static void Feladat06()
        {
            string valid = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (!valid.Contains(betu))
            {
                Console.Write("6. feladat: Kérek egy angol nagybetűt: ");
                string angolNagybetu = Console.ReadLine();
                if (angolNagybetu.Length == 1)
                    betu = char.Parse(angolNagybetu);
            }
        }
        private static void Feladat07()
        {
            int i = 0;
            while (i < karakterBank.Count && karakterBank[i].Betu != betu) i++;
            Console.WriteLine("7. feladat: ");
            if (i < karakterBank.Count)
                karakterBank[i].Megjelenit();
            else Console.Write("Nincs ilyen karakter a bankban!");
        }
        private static void Feladat08()
            => dekodol = Beolvas(@"..\..\..\src\dekodol.txt");
        private static void Feladat09()
        {
            Console.WriteLine("9. feladat: Dekódolás");
            foreach (var k in dekodol)
            {
                int i = 0;
                while (i < karakterBank.Count && !karakterBank[i].Felismer(k)) i++;
                if (i < karakterBank.Count)
                    Console.Write(karakterBank[i].Betu);
                else Console.Write('?');
            }
            Console.Write('\n');
        }
    }
}