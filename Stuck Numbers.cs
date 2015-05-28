using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class StuckNumbers
{
    static void Main()
    {
        int numInput = int.Parse(Console.ReadLine());
        string[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int count = 0;
        foreach (var a in numbers)
        {
            foreach (var b in numbers)
            {
                foreach (var c in numbers)
                {
                    foreach (var d in numbers)
                    {
                        if ((a != b) && (a != c) && (a != d) && (b != c) && (b != d) && (c != d))
                        {
                            if (a + b == c + d)
                            {
                                Console.WriteLine("{0}|{1}=={2}|{3}", a, b, c, d);
                                count++;
                            }
                        }
                    }
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("No");
        }
    }
}
