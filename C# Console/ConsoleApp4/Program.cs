using StudentLibrary;

namespace ConsoleApp4;

abstract class Program
{
	static void Main(string[] args)
	{
		StudentList list = new();
		list.Created += (s, stu) =>
			Console.WriteLine(
				$"Student Added to List: Id: {stu.Id}, Name: {stu.Name}, Gender: {stu.Gender}, Score: {stu.Score}, Grade: {stu.Grade(stu.Score)}");
		list.Readed += (s, stu) => Console.WriteLine("People Read!");
		list.Updated += (s, stu) => 
			Console.WriteLine(
				$"Student Id: {stu.Id} update with New Name: {stu.Name}, New Gender: {stu.Gender}, New Score: {stu.Score}, New Grade: {stu.Grade(stu.Score)}");
		list.Deleted += (s, stu) => Console.WriteLine($"People Deleted: {stu.Name}");

		/*list.Create(new Student(1, "Lim Haiheng", "Male", 100));
		list.Create(new Student(2, "Kamado Tanjiro", "Male", 85));
		list.Create(new Student(3, "Inosuke Hashibira", "Female", 65));
		
		PrintStudent(list);

		list.Update(3, "Inosuke Hashibira", "Male", 75);
		PrintStudent(list);

		list.Delete(3);
		PrintStudent(list);*/

		list.Initialize("Student.txt");
		PrintStudent(list);

		list.Delete(2);
		PrintStudent(list);
	}

	static void PrintStudent(StudentList? stuList)
	{
		Student s = new Student();
		if (stuList == null) return;
		
		NotifyStudentInList(s, stuList);
		Console.WriteLine(s.Heading);
		foreach (var stu in stuList.Students)
		{
			Console.WriteLine(stu.Info);
		}
	}

	static void NotifyStudentInList(Student? stu, StudentList list)
	{
		if (stu != null)
		{
			list.Read(stu);
		}
	}
}