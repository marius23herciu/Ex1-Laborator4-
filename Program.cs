using System;

namespace Ex1_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1
            //Scrieti un program care va citi un vector de intregi de dimensiune n de la tastaura. Scrieti o
            //functie care va inversa elementele vectorului, apelati-o si afisati-I rezultatul

            Console.WriteLine("Introduceti numarul de elemente al vectorului: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti " + n + " numere:");
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector[i] = int.Parse(Console.ReadLine());
            }

            int[] inversVector = InversareVector(vector);
            Console.WriteLine("Inversul vectorului este: ");
            foreach (var numar in inversVector)
            {
                Console.Write(numar + " ");
            }

        }
        static int[] InversareVector(int[] vector)
        {
            int startIndex = 0;
            for (int i = vector.Length - 1; i >= vector.Length / 2; i--)
            {
                int aux = vector[i];
                vector[i] = vector[startIndex];
                vector[startIndex] = aux;
                startIndex++;
            }

            return vector;
        }
    }
}
