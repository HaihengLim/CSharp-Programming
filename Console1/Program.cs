namespace ConsoleApp1;

internal class Program
{
    static void DisplayFileContent()
    {
        if (!File.Exists("People.txt"))
        {
            Console.WriteLine("No data file found");
            return;
        }

        var lines = File.ReadAllLines("People.txt");
        string info = "";

        foreach(var line in lines)
        {
            People p = new People();
            if (p.SetTextData(line))
            {
                if (info != "") info += "\n";
                info += p.Info;
            }
        }

        string heading = People.GetHeading();
        string bar = new string('-', heading.Length);
        Console.WriteLine(heading);
        Console.WriteLine(bar);
        Console.WriteLine(info);
    }

    static void UpdateFile(string targetName, string newGender, byte newAge)
    {
        if (!File.Exists("People.txt")) return;

        var lines = new List<string>(File.ReadAllLines("People.txt"));
        for(int i = 0; i < lines.Count; i++)
        {
            People p = new People();
            if (p.SetTextData(lines[i]))
            {
                if(p.Name.Equals(targetName, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = $"{targetName}/{newGender}/{newAge}";
                    break;
                }
            }
        }
        File.WriteAllLines("People.txt", lines);
    }

    static void Main(string[] args)
    {
        string? targetName;
        string? newGender;
        byte newAge;
        Console.WriteLine("Before Update:");
        DisplayFileContent();

        Console.WriteLine("Input Update Information!");
        Console.Write("Enter Target Name: "); targetName = Console.ReadLine() ?? "null";
        Console.Write("Enter New Gender: "); newGender = Console.ReadLine() ?? "null";
        Console.Write("Enter New Age: "); newAge = byte.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("After Update:\n");
        UpdateFile(targetName, newGender, newAge);
        
        Console.WriteLine("After Update:");
        DisplayFileContent();
    }
}
