using System;
using System.Linq; // Necesario para Enumerable y ToArray()

public class Algoritmo
{
    public int[] GenerarNumeros(int n)
    {
        // Semilla fija (42) garantiza que todos los alumnos ordenen la misma secuencia
        Random r = new Random(42);
        return Enumerable.Range(0, n).Select(_ => r.Next(0, 50000)).ToArray();
    }

    public bool EstaOrdenado(int[] arr)
    {
        if (arr == null || arr.Length == 0) return true;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            // Si el actual es mayor al siguiente, no está ordenado
            if (arr[i] > arr[i + 1]) return false;
        }
        return true;
    }

    public void BubbleSort(int[] arr)
    {
        // TODO: Implementar el algoritmo de Bubble Sort tradicional

        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            // Bandera si no hay intercambios, el arreglo ya está ordenado
            bool intercambio = false;
            
            // El último i elementos ya esta en su lugar
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Intercambio (swap)
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    intercambio = true;
                }
            }
            
            // Si no hubo intercambios,  terminamos temprano porque el arreglo ya está ordenado
            if (!intercambio)
                break;
        }


    }
}
