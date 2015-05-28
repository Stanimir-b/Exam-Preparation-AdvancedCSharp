using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class XRemoval
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char[]> inputMatrix = new List<char[]>();
        List<char[]> outputMatrix = new List<char[]>();
        while (input != "END")
        {
            inputMatrix.Add(input.ToLower().ToCharArray());
            outputMatrix.Add(input.ToCharArray());
            input = Console.ReadLine();
        }
        for (int row = 0; row < inputMatrix.Count - 2; row++)
        {
            int maxLength = Math.Min(inputMatrix[row].Length - 2,
                  Math.Min(inputMatrix[row + 1].Length - 1, inputMatrix[row + 2].Length - 2));
            for (int col = 0; col < maxLength; col++)
            {
                char first = inputMatrix[row][col];
                char second = inputMatrix[row][col + 2];
                char third = inputMatrix[row + 1][col + 1];
                char fourth = inputMatrix[row + 2][col];
                char fifth = inputMatrix[row + 2][col + 2];
                if (first == second && second == third && third == fourth && fourth == fifth)
                {
                    outputMatrix[row][col] = '\0';
                    outputMatrix[row][col + 2] = '\0';
                    outputMatrix[row + 1][col + 1] = '\0';
                    outputMatrix[row + 2][col] = '\0';
                    outputMatrix[row + 2][col + 2] = '\0';
                }
            }
        }
        foreach (var matrix in outputMatrix)
        {
            foreach (var ch in matrix)
            {
                if (ch != '\0')
                {
                    Console.Write(ch);
                }
            }
            Console.WriteLine();
        }
    }
}
