public class Program
{
    public static List<int> GetGrades()
    {
        return new List<int> { 85, 90, 78, 92, 88, 43 };
    }

    public static int GetAverage(List<int> grades)
    {
        var result = 0;
        foreach (var grade in grades)
        {
            result += grade;
        }

        return result / grades.Count;
    }

    public static void Main(string[] args)
    {
        var grades = GetGrades();
        var result = GetAverage(grades);

        Console.WriteLine($"Average: {result}");
    }
}