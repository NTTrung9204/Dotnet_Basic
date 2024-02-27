using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bai2
{
    class Program
    {
        static void HV(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void A(out int x)
        {
            x = 5;
        }
        static void Main(string[] args)
        {
            // int m, n, t;
            // m = Convert.ToInt32(Console.ReadLine());
            // n = Convert.ToInt32(Console.ReadLine());
            // HV(ref m, ref n);
            // A(out t);
            // Console.WriteLine("m = {0}, n = {1}, t = {2}", m, n, t);

            // string[] A = new string[5];

            // for (int i = 0; i < A.Length; i++)
            // {
            //     Console.Write("Nhap phan tu thu {0}: ", i);
            //     A[i] = Console.ReadLine();
            // }

            // for (int i = 0; i < A.Length; i++)
            // {
            //     Console.WriteLine("A[{0}] = {1}", i, A[i]);
            // }

            // foreach(string item in A)
            // {
            //     Console.WriteLine(item);
            // }

            // double[,] matrix = new double[10, 10];
            // int count = 0;
            // for (int i = 0; i < 10; i++)
            // {
            //     for (int j = 0; j < 10; j++)
            //     {
            //         matrix[i, j] = ++count;
            //     }
            // }
            // foreach (double item in matrix)
            // {
            //     Console.WriteLine(item);
            // }

            // Console.WriteLine();

            // string[][] software = new string[3][];
            // software[0] = new string[] { "Visual Studio", "Visual Code" };
            // software[1] = new string[] { "SQL Server", "MySQL" };
            // software[2] = new string[] { "Windows", "Linux" };

            // for(int i = 0; i < software.GetLength(0); i++)
            // {
            //     for(int j = 0; j < software[i].GetLength(0); j++)
            //     {
            //         Console.WriteLine(software[i][j]);
            //     }
            // }

            // foreach (string[] item in software)
            // {
            //     foreach (string item2 in item)
            //     {
            //         Console.WriteLine(item2);
            //     }
            // }

            // SV s1  = new SV();
            // SV s2 = new SV(1, "Nguyen Van A", 9.5);
            // SV s3 = new SV(s1);

            // s3.setName(s2.getName());

            // s2.Name = "Nguyen Van B";
            // s2.DTB = s3.DTB;

            // s1.Show();
            // s2.Show();
            // s3.Show();

            SV s1 = new SV{MSSV = 1, Name = "Nguyen Van A", DTB = 9.5};
            Console.WriteLine(s1.ToString());

        }
    }
}