namespace AdventOfCode2022;

public class Day3
{
	public Day3()
	{
	}

    static int CharToNumber(char c)
    {
        return char.IsUpper(c) ? char.ToLower(c) - 'a' + 27 : c - 'a' + 1;
    }

    public static int PartOne() {
        // Find matching char in each half of string

        // Read in file
        List<string> data = Utilites.GetFileLines("Day3.txt");

        int sumOfDups = 0;
        // Each line split into two halfs
        foreach (string line in data) {
            string firstHalf = line.Substring(0, line.Length / 2);
            string secondHalf = line.Substring(line.Length / 2);

            // Convert to sets and compare intersection
            IEnumerable<char> intersection = firstHalf.Intersect(secondHalf);
            sumOfDups += intersection.Select(CharToNumber).Sum();
        }

        return sumOfDups;
	}

    public static int PartTwo() {
        // Find the matching char in chunks of three.

        // Read in file
        List<string> data = Utilites.GetFileLines("Day3.txt");

        int sumOfDups = 0;
        for(int i = 0; i < data.Capacity; i+=3) 
        {
            string firstElf = data[i];
            string secondElf = data[i+1];
            string thirdElf = data[i+2];

            // Convert to sets and compare intersection
            IEnumerable<char> intersection = firstElf.Intersect(secondElf)
                .Intersect(thirdElf);
            sumOfDups += intersection.Select(CharToNumber).Sum();
        }

        return sumOfDups;
    }
}

