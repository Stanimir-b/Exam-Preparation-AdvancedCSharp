# Exam-Preparation-AdvancedCSharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CouplesFrequency
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int numberOfCouple = numbers.Length - 1;
        Dictionary<string, int> coupleFrequency = new Dictionary<string, int>();
        for (int i = 1; i < numbers.Length; i++)
        {
            string curentCouple = string.Format("{0} {1}", numbers[i - 1], numbers[i]);
            if (!coupleFrequency.ContainsKey(curentCouple))
            {
                coupleFrequency.Add(curentCouple, 0);
            }
            coupleFrequency[curentCouple]++;
        }
        foreach (var couple in coupleFrequency)
        {
            double frequency = couple.Value * 100.0 / numberOfCouple;
            Console.WriteLine("{0} -> {1:F2}%", couple.Key, frequency);
        }
    }
}
