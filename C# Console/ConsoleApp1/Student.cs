namespace ConsoleApp1;

public class Student
{
	private const int IdFieldWidth = -8;
	private const int NameFieldWidth = -20;
	private const int GenderFieldWidth = -10;
	private const int ScoreFieldWidth = 10;
	
	public int Id { get; set; }
	public string? Name { get; set; }
	public Gender? Gender { get; set; }
	public double Score { get; set; }

	// ReSharper disable once ConvertToPrimaryConstructor
	public Student(){}
	public Student(int id, string? name, string? gender, double score)
	{
		Id = id;
		Name = name;
		if (Enum.TryParse(gender, ignoreCase: true, out Gender parsedGender))
		{
			Gender = parsedGender;
		}
		else
		{
			Gender = null;
		}
		Score = score;
	}

	public string Header =>
		$"{"Id",IdFieldWidth} {"Name",NameFieldWidth} {"Gender",GenderFieldWidth} {"Score",ScoreFieldWidth}";

	public string Info => $"{Id, IdFieldWidth} {Name, NameFieldWidth} {Gender, GenderFieldWidth} {Score, ScoreFieldWidth}";
}