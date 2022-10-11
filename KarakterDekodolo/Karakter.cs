namespace KarakterDekodolo
{
    internal class Karakter
    {
        public char Betu { get; set; }
        public int[,] Matrix { get; set; }

        public bool Felismer(Karakter karakter)
        {
            for (int s = 0; s < Matrix.GetLength(0); s++)
            {
                for (int o = 0; o < Matrix.GetLength(1); o++)
                {
                    if (karakter.Matrix[s, o] != Matrix[s, o])
                        return false;
                }
            }
            return true;
        }
        public void Megjelenit()
        {
            for (int s = 0; s < Matrix.GetLength(0); s++)
            {
                for (int o = 0; o < Matrix.GetLength(1); o++)
                {
                    if (Matrix[s, o] == 1)
                        Console.Write("X");
                    else Console.Write(" ");
                }
                Console.Write('\n');
            }
        }

        public Karakter(char betu, int[,] matrix)
        {
            Betu = betu;
            Matrix = matrix;
        }
    }
}
