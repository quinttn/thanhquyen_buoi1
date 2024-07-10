using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan
{
    internal class TimKiemNhiPhan
    {
        const int MAX = 100;

        static void NhapMang(int[] a, ref int n)
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

        static void XuatMang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t{a[i]}");
            }
            Console.WriteLine();
        }

        static void QuickSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int s = Partition(a, left, right);
                QuickSort(a, left, s - 1);
                QuickSort(a, s + 1, right);
            }
        }

        static int Partition(int[] a, int left, int right)
        {
            int k = (left + right) / 2, x = a[k], l = left, r = right;
            do
            {
                while (a[l] < x)
                    l++;
                while (a[r] > x)
                    r--;
                if (l <= r)
                {
                    Swap(ref a[l], ref a[r]);
                    l++;
                    r--;
                }
            } while (l <= r);
            return l - 1;
        }

        static void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }

        static int BinarySearch(int[] a, int left, int right, int x)
        {
            if (left > right)
                return -1;

            int mid = (left + right) / 2;
            if (a[mid] == x)
                return mid;
            if (a[mid] > x)
                return BinarySearch(a, left, mid - 1, x);
            else
                return BinarySearch(a, mid + 1, right, x);
        }

        static void Main()
        {
            int[] a = new int[MAX];
            int n = 0; // Khởi tạo biến n

            NhapMang(a, ref n);
            Console.WriteLine("Mang da nhap:");
            XuatMang(a, n);

            // Sắp xếp mảng trước khi tìm kiếm nhị phân
            QuickSort(a, 0, n - 1);

            Console.WriteLine("\nMang sau khi sap xep la:");
            XuatMang(a, n);

            Console.Write("\nNhap x can tim: ");
            int x = int.Parse(Console.ReadLine());

            int kq = BinarySearch(a, 0, n - 1, x);
            if (kq == -1)
                Console.WriteLine($"Khong tim thay {x} trong mang");
            else
                Console.WriteLine($"Tim thay {x} tai vi tri thu {kq}");
        }
    }
}
