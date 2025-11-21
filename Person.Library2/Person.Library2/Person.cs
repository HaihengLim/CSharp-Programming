namespace Person.Library2;

public class Person
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = "";
    public Gender Gender { get; set; }
    public byte Age { get; set; } = 0;

    public static int id = 0;

    public void Create()
    {
        Console.Write("Enter Name: "); string name = Console.ReadLine() ?? "Unknown";
        Console.Write("Enter Gender: "); Gender gender;
        while (!Enum.TryParse<Gender>(Console.ReadLine(), out gender))
        {
            Console.WriteLine("Invalid Input!");
            Console.Write("Enter Gender Again: ");
        }
        Console.Write("Enter Age: "); byte age;
        while (!byte.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Invalid Input!");
            Console.Write("Enter Age Again: ");
        }

        Id = ++id;
        Name = name;
        Gender = gender;
        Age = age;
    }

    public string Heading
    {
        get
        {
            return $"{"Id",5} {"Name",-25} {"Gender",-10} {"Age",8}";
        }
    }

    public string Info
    {
        get
        {
            return $"{Id,5} {Name,-25} {Gender,-10} {Age,8}";
        }
    }

    public string getBar(char seperator)
    {
        return new string(seperator, Heading.Length);
    }
}