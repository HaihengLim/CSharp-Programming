namespace StudentConsole;

public class Student
{
    public int Id { get; set; }
    public string? Name{ get; set; }
    public string? Gender { get; set; }
    public byte Age { get; set; }
    public int Score { get; set; }
    public string Grade {
        get {
            return Score switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                >= 50 => "E",
                _ => "F"
            };
        }
    }
}
