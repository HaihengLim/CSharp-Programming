namespace ConsoleApp1;

public class People
{
    private string? name = "";
    private string? gender = "";
    private byte age = 0;

    public bool SetTextData(string data)
    {
        var parts = data.Split('/');
        if (parts == null) return false;
        if (parts.Length < 3) return false;
        //byte a = byte.Parse(parts[2]);
        if (byte.TryParse(parts[2], out byte a) == false) return false;
        name = parts[0].Trim();
        gender = parts[1].Trim();
        age = a;
        return true;
    }

    public string Info
    {
        get{
            return $"{name,-30} {gender,-8} {age,5}";
        }
    }

    public static String GetHeading()
    {
        return $"{"Name",-30} {"Gender",-8} {"Age",5}";
    }

    public string ToFileFormat()
    {
        return $"{name}/{gender}/{age}";
    }

    public string Name => name ?? "";
}
