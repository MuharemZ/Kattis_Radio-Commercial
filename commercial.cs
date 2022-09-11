using System;

namespace Problem_A
{
public class commercial
{
    public static void Main(string[] args)
    {
        int N = 0;
        int P = 0;
        int[] profitArray = null;
        var profitSum = 0;
        var maxEndingHere = 0;
        var maxSoFar = 0;

        
        var line = Console.ReadLine();
        
        var parts = line.Split(' ');
        N = int.Parse(parts[0]);
        P = int.Parse(parts[1]);
        
        line = Console.ReadLine();
        parts = line.Split(' ');

        
        profitArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            profitArray[i] = int.Parse(parts[i]) - P;
        }
         
        maxEndingHere = profitArray[0];
        maxSoFar = profitArray[0];
        
        for (int i = 0; i < profitArray.Length; i++)
        {
            maxEndingHere = maxEndingHere + profitArray[i];
            if (profitArray[i] > maxEndingHere)
            {
                maxEndingHere = profitArray[i];
            }
            if (maxSoFar < maxEndingHere)
            {
                maxSoFar = maxEndingHere;
            }
        }
        profitSum = maxSoFar;
        Console.WriteLine(profitSum);
        }
    }
}