using System;

class Program
{
    static void Main()
    {
        // Nhập hệ số a, b, c
        Console.Write("Nhap he so a, b, c: ");
        string[] input = Console.ReadLine().Split();
        float a = float.Parse(input[0]);
        float b = float.Parse(input[1]);
        float c = float.Parse(input[2]);

        // Giải phương trình
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c != 0 ? "PTVN" : "PT co VSN");
            }
            else
            {
                float x1 = -c / b;
                Console.WriteLine("PT co nghiem x = " + x1);
            }
        }
        else
        {
            float delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("PTVN");
            }
            else if (delta == 0)
            {
                float x1 = -b / (2 * a);
                Console.WriteLine("PT co nghiem kep x1 = x2 = " + x1);
            }
            else
            {
                float x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                float x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("PT co 2 nghiem phan biet : ");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
        }
    }
}