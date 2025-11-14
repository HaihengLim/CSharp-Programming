namespace WinFormsApp4;

public class Person
{
    public static string DataSeparator { get; set; } = "/";

    public static event Action<Person>? Created;
    public static Person? Create(string data)
    {
        string[] arr = data.Split(DataSeparator);
        if (arr.Length < 3) return null;
        if (Enum.TryParse<Gender>(arr[1], out Gender gender) == false) return null;
        if (byte.TryParse(arr[2], out byte age) == false) return null;
        var p = new Person(arr[0].Trim(), gender, age);
        Created?.Invoke(p);
        return p;
    }

    public Person() { }

    public Person(string name, Gender gender, byte age)
    {
        this.SetData(name, gender, age);
    }
    public string Id => _id;
    public string Name { get; set; } = default!;
    public Gender Gender { get; set; } = default!;
    public byte Age { get; set; } = default;
    public object? Tag { get; set; } = default;
    public Person SetData(string name, Gender gender, byte age)
    {
        Name = name;
        Gender = gender;
        Age = age;
        return this;
    }
    private string _id = Guid.NewGuid().ToString();
}