using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSort
    {
        const int MAX = 100;

        static void nhapMang(int[] a, ref int n)
        {
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

        static void merge(int[] a, int l, int m, int r)
        {
            int[] b = new int[r - l + 1];
            int i, j, k;
            i = l;
            j = m + 1;
            for (k = 0; k <= r - l; k++)
            {
                if (i <= m && (j > r || a[i] <= a[j]))
                {
                    b[k] = a[i++];
                }
                else
                {
                    b[k] = a[j++];
                }
            }
            for (k = l; k <= r; k++)
            {
                a[k] = b[k - l];
            }
        }

        static void mergeSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int mid = (l + r) / 2;
                mergeSort(a, l, mid);
                mergeSort(a, mid + 1, r);
                merge(a, l, mid, r);
            }
        }

        static void Main()
        {
            int[] a = new int[MAX];
            int n;

            do
            {
                Console.Write("Nhap so phan tu cua mang: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0 || n > MAX);

            nhapMang(a, ref n);

            Console.WriteLine("\nMang chua duoc sap xep: ");
            xuatMang(a, n);

            mergeSort(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi duoc sap xep: ");
            xuatMang(a, n);
        }
    }
}
