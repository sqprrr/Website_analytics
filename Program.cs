using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileDay1 = "day1.csv";
        string fileDay2 = "day2.csv";

        var day1 = LoadCsv(fileDay1);
        var day2 = LoadCsv(fileDay2);

        foreach (var kvp in day2)
        {
            var userId = kvp.Key;
            var productsDay2 = kvp.Value;

            if (day1.ContainsKey(userId))
            {
                var productsDay1 = day1[userId];
                var newProducts = new HashSet<string>(productsDay2);
                newProducts.ExceptWith(productsDay1);

                if (newProducts.Count > 0)
                {
                    Console.WriteLine(userId);
                }
            }
        }
    }

    static Dictionary<string, HashSet<string>> LoadCsv(string path)
    {
        var dict = new Dictionary<string, HashSet<string>>();

        foreach (var line in File.ReadLines(path))
        {
            var parts = line.Split(',');
            if (parts.Length < 2) continue; 

            string userId = parts[0];
            string productId = parts[1];

            if (!dict.ContainsKey(userId))
                dict[userId] = new HashSet<string>();

            dict[userId].Add(productId);
        }

        return dict;
    }
}
