namespace ConsoleApp1;

public class StudentList
{
	public event EventHandler<Student>? Added;
	public event EventHandler<Student>? Updated;
	public event EventHandler<Student>? Deleted;
	public List<Student> Students = new();

	public bool Add(Student? stu)
	{
		if (stu == null) return false;
		if (!IsStudentIdValid(stu.Id)) return false;
		if (!IsStudentNameValid(stu.Name)) return false;
		if (!IsStudentGenderValid(stu.Gender)) return false;
		if (!IsStudentScoreValid(stu.Score)) return false;
		
		Students.Add(stu);
		Added?.Invoke(this, stu);
		return true;
	}

	public bool Update(int id, string? newName = null, double? newScore = null)
	{
		var student = Students.FirstOrDefault(p => p.Id == id);

		if (student == null) return false;

		if (newName != null && IsStudentNameValid(newName)) student.Name = newName;
		if (newScore.HasValue && IsStudentScoreValid(newScore.Value)) student.Score = newScore.Value;

		Updated?.Invoke(this, student);
		return true;
	}

	public bool Delete(int id)
	{
		var student = Students.FirstOrDefault(p => p.Id == id);
		if (student == null) return false;
		if (!IsStudentIdValid(id)) return false;
		
		Students.Remove(student);
		Deleted?.Invoke(this, student);
		return true;
	}

	private bool IsStudentIdValid(int id)
	{
		return id >= 0;
	}

	private bool IsStudentNameValid(string? name)
	{
		return !string.IsNullOrEmpty(name);
	}

	private bool IsStudentGenderValid(Gender? gender)
	{
		return gender != null && Enum.IsDefined(typeof(Gender), gender.Value);
	}

	private bool IsStudentScoreValid(double score)
	{
		return score >= 0;
	}
}