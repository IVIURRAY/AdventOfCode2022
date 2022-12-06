namespace AdventOfCode2022
{
    public class Utilites
	{
        public Utilites()
		{
		}

		public static List<string> GetFileLines(string file)
		{
            return File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "..//..//..//Input//" + file))
           .Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
           .ToList();
        }
	}
}

