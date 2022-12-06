namespace AdventOfCode2022;

public class Day4
{
	public Day4()
	{
	}

	public static int PartOne()
	{
		List<string> data = Utilites.GetFileLines("Day4.txt");

		int overlapping = 0;
		foreach (string line in data)
		{
            string[] splitLine = line.Split(",");
			int start1 = int.Parse(splitLine[0].Split("-")[0]);
            int end1 = int.Parse(splitLine[0].Split("-")[1]);

            int start2 = int.Parse(splitLine[1].Split("-")[0]);
            int end2 = int.Parse(splitLine[1].Split("-")[1]);

			if (
				((start1 <= start2) & (end1 >= end2)) |
				((start2 <= start1) & (end2 >= end1))
                )
			{
                overlapping += 1;
			}

        }

        return overlapping;
	}

    public static int PartTwo()
    {
        List<string> data = Utilites.GetFileLines("Day4.txt");

        int overlapping = 0;
        foreach (string line in data)
        {
            string[] splitLine = line.Split(",");
            int start1 = int.Parse(splitLine[0].Split("-")[0]);
            int end1 = int.Parse(splitLine[0].Split("-")[1]);

            int start2 = int.Parse(splitLine[1].Split("-")[0]);
            int end2 = int.Parse(splitLine[1].Split("-")[1]);

            if (
                ((start1 <= start2) & (end1 >= end2)) | ((start2 <= start1) & (end2 >= end1)) |
                ((end1 <= end2) & (end1 >= start2)) |
                ((start1 <= end2) & (start1 >= start2))
               )
            {
                overlapping += 1;
            }

        }

        // 664
        return overlapping;
    }
}

