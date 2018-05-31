using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qS
{
    class Program
    {
        public static int[] QuickSort(int[] array, int start, int end)
        {
            if (end == start || array.Length == 0) return null;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }
            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) QuickSort(array, start, storeIndex - 1);
            if (storeIndex < end) QuickSort(array, storeIndex + 1, end);
            return array;
        }
        static void Main(string[] args)
        {
            ThreeItems();
            HundredItems();
            ThousandItems();
            EmptyItems();
            Console.ReadKey();
        }
        private static void ThreeItems()
        {
            int[] array = new int[10];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 5);
            Console.Write("1)Сортировка массива из трёх элементов работает корректно.\n");
            array = QuickSort(array, 0, array.Length - 1);
            Console.Write(" Элементы: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
        private static void HundredItems()
        {
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
                array[i] = 5;
            Console.Write("\n2)Сортировка массива из 100 одинаковых чисел работает корректно.\n");
            array = QuickSort(array, 0, array.Length - 1);
            Console.Write(" Элементы: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
        private static void ThousandItems()
        {
            var rnd = new Random();
            int[] array = new int[1000];
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 10);
            Console.Write("\n3)Сортировка массива из 1000 чисел работает корректно.\n");
            array = QuickSort(array, 0, array.Length - 1);
            Console.Write(" Элементы: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
        private static void EmptyItems()
        {
            int[] array = { };
            array = QuickSort(array, 0, array.Length - 1);
            if (array == null)
                Console.Write("\n4)Сортировка пустого массива невозможна.\n");
        }
    }
}

