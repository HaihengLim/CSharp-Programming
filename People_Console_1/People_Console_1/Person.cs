namespace People_Console_1;

internal class Person
{
    private const char seperator = '-';

    public delegate void PersonHandler(Person per);

    public static event PersonHandler? Created;

    public static void Create()
    {
        Console.Write("Enter Name: "); string name = Console.ReadLine() ?? "Unknown";
        
        Console.Write("Enter Gender: "); Gender gender; while (!Enum.TryParse<Gender>(Console.ReadLine(), true, out gender))
        {
            Console.WriteLine("Wrong input Gender Please try again!");
            Console.Write("Enter Gender: ");
        }

        Console.Write("Enter Age: "); byte age;  while(!byte.TryParse(Console.ReadLine(), out age))
        { 
            Console.WriteLine("Wrong input age Please try again!");
            Console.Write("Enter Age: ");
        }

        Person newPer = new Person()
        {
            Name = name,
            Gender = gender,
            Age = age
        };
        Created?.Invoke(newPer);
    }

    public Person() { }

    public string Name { get; set; } = "";
    public Gender Gender { get; set; } = default;
    public byte Age { get; set; } = default;

    public string Info => $"{Name,-30} {Gender,-10} {Age + " years old", 15}";

    public static string Heading => $"{"Name",-30} {"Gender",-10} {"Age", 15}";

    public static void GetBar()
    {
        Console.WriteLine(new string(seperator, Heading.Length));
    }
}
