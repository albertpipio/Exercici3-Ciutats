using System;

namespace Ex3_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fase 1

            Console.WriteLine("Escriu el nom de la primera ciutat: ");
            string ciutat1 = Console.ReadLine();

            Console.WriteLine("Escriu el nom de la segona ciutat: ");
            string ciutat2 = Console.ReadLine();

            Console.WriteLine("Escriu el nom de la tercera ciutat: ");
            string ciutat3 = Console.ReadLine();

            Console.WriteLine("Escriu el nom de la quarta ciutat: ");
            string ciutat4 = Console.ReadLine();

            Console.WriteLine("Escriu el nom de la cinquena ciutat: ");
            string ciutat5 = Console.ReadLine();

            Console.WriteLine("Escriu el nom de la sisena ciutat: ");
            string ciutat6 = Console.ReadLine();

            Console.WriteLine($"Les ciutats que has escrit són: {ciutat1}, {ciutat2}, {ciutat3}, {ciutat4}, {ciutat5}, i {ciutat6}.");

            //Fi Fase 1

            //Fase 2

            string [] arrayCiutats = new string [6];

            arrayCiutats [0] = ciutat1;
            arrayCiutats [1] = ciutat2;
            arrayCiutats [2] = ciutat3;
            arrayCiutats [3] = ciutat4;
            arrayCiutats [4] = ciutat5;
            arrayCiutats [5] = ciutat6;

            Array.Sort(arrayCiutats);

            Console.WriteLine("Aquestes són les ciutats per ordre alfabètic:");

            for (int i = 0; i < arrayCiutats.Length; i++)
            {
                Console.WriteLine(arrayCiutats[i]);
            }

            //Fi Fase 2

            //Fase 3

            string [] arrayCiutatsModificades = new string [6];

            arrayCiutatsModificades[0] = ciutat1.Replace("a", "4");
            arrayCiutatsModificades[1] = ciutat2.Replace("a", "4");
            arrayCiutatsModificades[2] = ciutat3.Replace("a", "4");
            arrayCiutatsModificades[3] = ciutat4.Replace("a", "4");
            arrayCiutatsModificades[4] = ciutat5.Replace("a", "4");
            arrayCiutatsModificades[5] = ciutat6.Replace("a", "4");
            
            Array.Sort(arrayCiutatsModificades);

            Console.WriteLine("Aquest és l'array modificat i per ordre alfabètic:");

            for (int i = 0; i < arrayCiutatsModificades.Length; i++)
            {
                Console.WriteLine(arrayCiutatsModificades[i]);
            }

            //Fi Fase 3

            //Fase 4

            string [] arrayCiutat1 = new string [ciutat1.Length];
            string [] arrayCiutat2 = new string [ciutat2.Length];
            string [] arrayCiutat3 = new string [ciutat3.Length];
            string [] arrayCiutat4 = new string [ciutat4.Length];
            string [] arrayCiutat5 = new string [ciutat5.Length];
            string [] arrayCiutat6 = new string [ciutat6.Length];

            for (int i = ciutat1.Length -1; i >= 0; i--)
            {
                arrayCiutat1[i] = ciutat1.Substring(i, 1);
            }

            for (int i = ciutat1.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat1[i]);
            }

            for (int i = ciutat2.Length -1; i >= 0; i--)
            {
                arrayCiutat2[i] = ciutat2.Substring(i, 1);
            }

            Console.WriteLine(" ");

            for (int i = ciutat2.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat2[i]);
            }

            Console.WriteLine(" ");

            for (int i = ciutat3.Length -1; i >= 0; i--)
            {
                arrayCiutat3[i] = ciutat3.Substring(i, 1);
            }

            for (int i = ciutat3.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat3[i]);
            }

            Console.WriteLine(" ");

            for (int i = ciutat4.Length -1; i >= 0; i--)
            {
                arrayCiutat4[i] = ciutat4.Substring(i, 1);
            }

            for (int i = ciutat4.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat4[i]);
            }

            Console.WriteLine(" ");

            for (int i = ciutat5.Length -1; i >= 0; i--)
            {
                arrayCiutat5[i] = ciutat5.Substring(i, 1);
            }

            for (int i = ciutat5.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat5[i]);
            }

            Console.WriteLine(" ");

            for (int i = ciutat6.Length -1; i >= 0; i--)
            {
                arrayCiutat6[i] = ciutat6.Substring(i, 1);
            }

            for (int i = ciutat6.Length -1; i >= 0; i--)
            {
                Console.Write(arrayCiutat6[i]);
            }

            //Fi Fase 4
        }
    }
}
