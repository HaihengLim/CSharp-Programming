namespace StudentLib;

public class Student
{
  private const int IdFieldWidth = -8;
  private const int NameFieldWidth = -20;
  private const int GenderFieldWidth = -10;
  private const int ScoreFieldWidth = 10;
  public int Id{get;set;}
  public string? Name{get;set;}
  public string? Gender{get;set;}
  public double Score{get;set;}

  public Student(int _id, string? _name, string _gender, double _score)
  {
    Id = _id;
    Name = _name;
    Gender = _gender;
    Score = _score;
  }

  public string Header => $"{"ID", IdFieldWidth} {"Name", NameFieldWidth} {"Gener", GenderFieldWidth} {"Score", ScoreFieldWidth}";
  public string Info => $"{Id, IdFieldWidth} {Name, NameFieldWidth} {Gender, GenderFieldWidth} {Score, ScoreFieldWidth}";
}
