namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v1 = new int[2];
            int[] v2 = new int[2];
            int[] v3 = new int[2];
            String linea;

            Console.WriteLine("1ºVECTOR: ");
            for (int i = 0; i < v1.Length; i++)
            {
                Console.Write("Valor posición ["+(i+1)+"]: ");
                linea= Console.ReadLine();
                v1[i] = int.Parse(linea);
            }
            Console.WriteLine("2ºVECTOR: ");
            for (int i = 0; i < v2.Length; i++)
            {
                Console.Write("Valor posición [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                v2[i] = int.Parse(linea);
            }

            Console.WriteLine("3ºVECTOR: ");
            for (int i = 0; i < v3.Length; i++)
            {
                v3[i] = v1[i] + v2[i];
                Console.Write(v3[i]+" ");
            }                   

        }
    }
}