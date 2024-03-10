namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3. Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B,
             * cada curso cuenta con 5 alumnos. Realizar un programa que muestre el curso que obtuvo el mayor promedio general.*/

            float[] vectorA = new float[5];
            float[] vectorB = new float[5];
            String linea;
            float sumA=0, sumaB=0;
            float promedioA = 0, promedioB=0;

            Console.WriteLine("Notas grupo A: ");
            for (int i = 0; i < vectorA.Length; i++)
            {
                Console.Write("[" + (i + 1) + "] Nota: ");
                linea = Console.ReadLine();
                vectorA[i] = float.Parse(linea);
                sumA += vectorA[i];

            }
            promedioA = sumA / vectorA.Length;
            Console.WriteLine("Promedio grupo A: " + promedioA);

            Console.WriteLine("Notas grupo B: ");
            for (int i = 0; i < vectorA.Length; i++)
            {
                Console.Write("[" + (i + 1) + "] Nota: ");
                linea = Console.ReadLine();
                vectorB[i] = float.Parse(linea);
                sumaB += vectorB[i];
            }
            promedioB = sumaB / vectorB.Length;
            Console.WriteLine("Promedio grupo B: " + promedioB);

            if (promedioA > promedioB)
            {
                Console.WriteLine("El promedio del grupo A es mayor.");
            }
            else if (promedioB > promedioA)
            {
                Console.WriteLine("El promedio del grupo B es mayor.");
            }
            else
            {
                Console.WriteLine("Los promedios de ambos grupos son iguales.");
            }

            Console.ReadKey();


        }
    }
}