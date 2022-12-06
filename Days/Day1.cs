using System.Reflection;

namespace AdventOfCode2022;

public class Day1
{

    public Day1()
    {
	}

    public static int PartOne()
    {
        List<string> data = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//Input//Day1.txt"))
            .Split("\n\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int maxCalories = 0;
        foreach (string line in data)
        {
            int elfsCalories = line.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList()
                .Sum();

            if (elfsCalories > maxCalories)
            {
                maxCalories = elfsCalories;
            }
        }

        return maxCalories;

    }

    public static int PartTwo()
    {
        
        List<string> data = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//Input//Day1.txt"))
            .Split("\n\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        List<int> elfsCalories = new List<int> { };
        foreach (string line in data)
        {
            int elfCalories = line.Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList()
                .Sum();

            elfsCalories.Add(elfCalories);
        }

        int maxCalories = 0;
        for (int i = 0; i < 3; i++)
        {
            int localMax = elfsCalories.Max();
            maxCalories += localMax;
            elfsCalories.Remove(localMax);
        }

        return maxCalories;
    }
}