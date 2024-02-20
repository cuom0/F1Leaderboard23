using System;

namespace F1Leaderboard
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Un codice di Cuomo Salvatore (Github: cuom0)
            Console.WriteLine("  ______ __   _                    _           _                         _ ");
            Console.WriteLine(" |  ____/_ | | |                  | |         | |                       | |");
            Console.WriteLine(" | |__   | | | |     ___  __ _  __| | ___ _ __| |__   ___   __ _ _ __ __| |");
            Console.WriteLine(" |  __|  | | | |    / _ \\/ _` |/ _` |/ _ \\ '__| '_ \\ / _ \\ / _` | '__/ _` |");
            Console.WriteLine(" | |     | | | |___|  __/ (_| | (_| |  __/ |  | |_) | (_) | (_| | | | (_| |");
            Console.WriteLine(" |_|     |_| |______\\___|\\__,_|\\__,_|\\___|_|  |_.__/ \\___/ \\__,_|_|  \\__,_|");

            /////////////////////////////////////////////////////////////////

            string[] driver = { "Red Bull - Max Verstappen", "Red Bull - Sergio Pérez", "Mercedes - Lewis Hamilton", "Aston Martin - Fernando Alonso", "Ferrari - Charles Leclerc", "McLaren - Lando Norris", "Ferrari - Carlos Sainz Jr.", "Mercedes - George Russell", "McLaren - Oscar Piastri", "Aston Martin - Lance Stroll", "Alpine - Pierre Gasly", "Alpine - Esteban Ocon", "Williams - Alexander Albon", "AlphaTauri - Yuki Tsunoda", "Alfa Romeo Racing - Valtteri Bottas", "Haas - Nico Hulkenberg", "AlphaTauri - Daniel Ricciardo", "Alfa Romeo Racing - Zhou Guanyu", "Haas - Kevin Magnussen", "AlphaTauri - Liam Lawson", "Williams - Logan Sargeant", "AlphaTauri - Nyck de Vries" };
            int[] pts = { 0, 1 , 2 , 3 , 6 , 6 , 9 , 10 , 17, 27, 58, 62 , 74 , 97, 175, 200, 205, 206, 206, 234, 285, 575};

            //Naive Sort
            /*
            for (int i = 0; i < pts.Length - 1; i++)
            {
                for (int j = i + 1; j < pts.Length; j++)
                {
                    if (pts[i] < pts[j])
                    {
                        int temp = pts[i];
                        pts[i] = pts[j];
                        pts[j] = temp;
                    }
                }
            }
            */

            //Bubble Sort

            bool s;
            do
            {
                s = false;
                for (int i = 0; i < pts.Length -1; i++)
                    if (pts[i] < pts[i + 1])
                    {
                        int temp = pts[i];
                        pts[i] = pts[i + 1];
                        pts[i + 1] = temp;
                        s = true;
                    }
            } while (s == true);

            Console.WriteLine(" ");
            for (int i = 0; i < pts.Length; i++)
            {
                Console.WriteLine($"{i+1}°: {driver[i]}\n{pts[i]}pts.\n\n");
            }
        }
    }
}
