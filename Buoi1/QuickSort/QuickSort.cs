using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSort
    {
        const int MAX = 100;

        static void nhapMang(int[] a, out int n)
        {
            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void xuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static void quickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = partition(a, left, right);
                quickSort(a, left, s - 1);
                quickSort(a, s + 1, right);
            }
        }

        static int partition(int[] a, int left, int right)
        {
            int k = (left + right) / 2, x = a[k], l = left, r = right;
            do
            {
                while (a[l] < x)
                    l++;
                while (a[r] > x)
                    r--;
                if (l < r)
                {
                    swap(ref a[l], ref a[r]);
                    l++;
                    r--;
                }
            } while (l < r);
            return r;
        }

        static void swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static void Main()
        {
            int[] a = new int[MAX];
            int n;
            nhapMang(a, out n);
            Console.WriteLine("Mang da nhap:");
            xuatMang(a, n);
            Console.WriteLine("\nMang sau khi sap xep la:");
            quickSort(a, 0, n - 1);
            xuatMang(a, n);
        }
    }
}
