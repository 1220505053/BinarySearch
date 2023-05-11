using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int BinarySearch(int[] arr, int value)
            {
                int left = 0;
                int right = arr.Length - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (arr[mid] == value)
                        return mid;
                    else if (arr[mid] < value)
                        left = mid + 1;
                    else
                        right = mid - 1;
                }

                return -1;
            }

            int[] dizi = { 4, 8, 3, 84, 47, 76, 9, 24, 68 };
            Array.Sort(dizi);

            int aranan = 84;
            int sonuc = BinarySearch(dizi, aranan);

            if (sonuc == -1)
                Console.WriteLine("Değer bulunamadı.");
            else
                Console.WriteLine("Değer {0}, dizinin {1}. turunda bulundu.", aranan, sonuc);





            Console.ReadKey();


        }
    }
}
