namespace ConsoleApp1;

public abstract class Program
{
	static void Main(string[] args)
	{
		StudentList list = new();

		list.Added += OnAddStudent;
		list.Updated += (s, stu) => Console.WriteLine($"Student Updated Name: {stu.Name}");
		list.Deleted += (s, stu) => Console.WriteLine($"Student Deleted Name: {stu.Name}");

		list.Add(new Student(1, "Haiheng", "Male", 100));
		list.Add(new Student(2, "Nika", "Female", 100));
		
		PrintStudent(list);

		list.Update(1, "Lim Haiheng", 95);
		PrintStudent(list);

		list.Delete(2);
		PrintStudent(list);
	}

	static void OnAddStudent(Object? sender, Student stu)
	{
		Console.WriteLine($"Added Student Name: {stu.Name}");
	}

	static void PrintStudent(StudentList? list)
	{
		if (list == null)
		{
			Console.WriteLine("Three are no students in the list.");
			return;
		}
		Student stu = new Student();
		Console.WriteLine(stu.Header);
		foreach (var s in list.Students)
		{
			Console.WriteLine(s.Info);
		}
	}
}