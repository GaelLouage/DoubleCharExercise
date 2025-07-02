using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DoubleChar("String"));
        Console.WriteLine(DoubleChar("Hello World"));
        Console.WriteLine(DoubleChar("1234!_ "));
    }
    public static string DoubleCharLinq(string s)
    {
        if(string.IsNullOrEmpty(s)) return string.Empty;
    
        return string.Concat(s.Select((x,i) => $"{x}{s[i]}"));
    }
    public static string DoubleChar(string s)
    {
        if (string.IsNullOrEmpty(s)) return string.Empty;

        var sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++) 
        {
            sb.Append($"{s[i]}{s[i]}");
        }

        return sb.ToString();
    }
}