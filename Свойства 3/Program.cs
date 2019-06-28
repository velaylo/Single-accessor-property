using System;

namespace Свойства_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numarr = new int[size];
            Console.WriteLine("Введите элементы массива: ");
            for(int i = 0; i < size; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                numarr[i] = element;
            }

            Array array = new Array(size,numarr);
         
            int sum = array.SumOfArrayElements;
            Console.Write($"Сумма элементов массива: {sum}");
            Console.ReadKey();
        }
    }

    class Array
    {
        private int size;
        public int[] numarr;

        public int SumOfArrayElements
        {
            get
            {
                int sum = 0;
                for(int i = 0; i < size; i++)
                {
                    sum += numarr[i];
                }
                return sum;
            }
        }

        public Array(int size,int[] numarr)
        {
            this.size = size;
            this.numarr = numarr;
        }
    }
}
