using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Preparamos una lista
        string[] noms = { "", "l' una", "les dues", "les tres", "les quatre",
                          "les cinc", "les sis", "les set", "les vuit",
                          "les nou", "les deu", "les onze", "les dotze" };

        // Aquí está el saludo
        Console.WriteLine("Hola Silvia ;) aquest és el meu rellotge en català...dóna l'hora com jo em sé .....");

        // Pongo una línea vacía para que quede mejor al dar la hora.
        Console.WriteLine();

        // 2. El bucle
        while (true)
        {
            // De aquí obtendremos la hora actual
            string horaNumerica = DateTime.Now.ToString("HH:mm");
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;

            // Aquí haremos el redondeo
            int residu = m % 5;

            if (residu <= 2)
            {
                // Redondeo hacia ABAJO
                m = m - residu;
            }
            else
            {
                // El redondeo hacia arriba 
                m = m + (5 - residu);
            }

            // Cuando llega al minuto 60 le sumaremos 1 hora
            if (m == 60)
            {
                m = 0;
                h = h + 1;
            }

            // Formato de 12 horas
            if (h > 12) h = h - 12;
            if (h == 0) h = 12;

            // Calculamos la hora siguiente
            int horaSeguent = h + 1;
            if (horaSeguent > 12) horaSeguent = 1;

            // Y mostramos la hora por pantalla
            Console.Write(horaNumerica + ": ");

            switch (m)
            {
                case 0:
                    Console.WriteLine(noms[h] + " en punt");
                    break;
                case 5:
                    Console.WriteLine(noms[h] + " i cinc");
                    break;
                case 10:
                    Console.WriteLine(noms[h] + " i deu");
                    break;
                case 15:
                    Console.WriteLine("Un quart de " + noms[horaSeguent]);
                    break;
                case 20:
                    Console.WriteLine("Un quart i cinc de " + noms[horaSeguent]);
                    break;
                case 25:
                    Console.WriteLine("Un quart i deu de " + noms[horaSeguent]);
                    break;
                case 30:
                    Console.WriteLine("Dos quarts de " + noms[horaSeguent]);
                    break;
                case 35:
                    Console.WriteLine("Dos quarts i cinc de " + noms[horaSeguent]);
                    break;
                case 40:
                    Console.WriteLine("Dos quarts i deu de " + noms[horaSeguent]);
                    break;
                case 45:
                    Console.WriteLine("Tres quarts de " + noms[horaSeguent]);
                    break;
                case 50:
                    Console.WriteLine("Tres quarts i cinc de " + noms[horaSeguent]);
                    break;
                case 55:
                    Console.WriteLine("Tres quarts i deu de " + noms[horaSeguent]);
                    break;
            }

            // Así esperamos 5' para volver a dar la hora.
            Thread.Sleep(300000);
        }
    }
}