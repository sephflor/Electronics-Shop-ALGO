using System;
using System.IO;
using System.Linq;

class Solution
{
    static int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int maxAffordable = -1;
        foreach (int k in keyboards)
        {
            foreach (int d in drives)
            {
                int cost = k + d;
                if (cost <= b && cost > maxAffordable)
                    maxAffordable = cost;
            }
        }
        return maxAffordable;
    }

    static void Main(string[] args)
    {
        string[] bnm = Console.ReadLine().Split(' ');
        int b = int.Parse(bnm[0]);
        int n = int.Parse(bnm[1]);
        int m = int.Parse(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int moneySpent = getMoneySpent(keyboards, drives, b);
        Console.WriteLine(moneySpent);
    }
}
