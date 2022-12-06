namespace AdventOfCode2022;

public class Day2
{
	public Day2()
	{
	}

    static int PlayGame(char rps, char choice)
    {
        // A = Rock, X = Rock
        // B = Paper, Y = Paper
        // C = Scissors, Z = Scissors
        if (rps == 'A' & choice == 'X')
        {
            return 1 + 3;
        }
        else if (rps == 'B' & choice == 'Y')
        {
            return 2 + 3;
        }
        else if (rps == 'C' & choice == 'Z')
        {
            return 3 + 3;
        }
        else if (rps == 'A' & choice == 'Y')
        {
            return 2 + 6;
        }
        else if (rps == 'A' & choice == 'Z')
        {
            return 3 + 0;
        }
        else if (rps == 'B' & choice == 'X')
        {
            return 1 + 0;
        }
        else if (rps == 'B' & choice == 'Z')
        {
            return 3 + 6;
        }
        else if (rps == 'C' & choice == 'X')
        {
            return 1 + 6;
        }
        else if (rps == 'C' & choice == 'Y')
        {
            return 2 + 0;
        }
        else
        {
            return -1000000000;
        }
    }

    public static int PartOne()
	{


        List<string> data = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//Input//Day2.txt"))
            .Split("\n", StringSplitOptions.RemoveEmptyEntries)
			.ToList();

		int score = 0;
        foreach (string line in data) {
            score += PlayGame(line[0], line[2]);
        }


        return score;
	}

    static int PlayGame2(char rps, char needTo)
    {
        // A = Rock, X = Lose
        // B = Paper, Y = Dawn
        // C = Scissors, Z = Win
        if (rps == 'A' & needTo == 'X')
        {
            return 3 + 0;
        }
        else if (rps == 'A' & needTo == 'Y')
        {
            return 1 + 3;
        }
        else if (rps == 'A' & needTo == 'Z')
        {
            return 2 + 6;
        }
        else if (rps == 'B' & needTo == 'X')
        {
            return 1 + 0;
        }
        else if (rps == 'B' & needTo == 'Y')
        {
            return 2 + 3;
        }
        else if (rps == 'B' & needTo == 'Z')
        {
            return 3 + 6;
        }
        else if (rps == 'C' & needTo == 'X')
        {
            return 2 + 0;
        }
        else if (rps == 'C' & needTo == 'Y')
        {
            return 3 + 3;
        }
        else if (rps == 'C' & needTo == 'Z')
        {
            return 1 + 6;
        }
        else
        {
            return -1000000000;
        }
    }

    public static int PartTwo()
    {
        List<string> data = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//Input//Day2.txt"))
            .Split("\n", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        int score = 0;
        foreach (string line in data)
        {
            score += PlayGame2(line[0], line[2]);
        }


        return score;
    }

}