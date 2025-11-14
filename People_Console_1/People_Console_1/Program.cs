namespace People_Console_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonList perList = new();
            Console.Write("Enter Number of Person: "); byte n;
            while(!byte.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input Please Try Again!");
                Console.Write("Enter Number of Person: ");
            }
            InputAll(n);
            Pause();

            var pers = perList.Elements;
            Console.WriteLine("Output All Data: ");
            Console.WriteLine(Person.Heading);
            Person.GetBar();
            perList.Elements.ForEach(p =>
            {
                Console.WriteLine(p.Info);
            });
        }

        static void Pause()
        {
            Console.WriteLine("Please press any key to continue...!");
            Console.ReadKey();
        }

        static void InputAll(byte n)
        {
            for (var i = 0; i < n; i++)
            {
                Console.WriteLine($"Please Input Data for Person {i + 1}:");
                Person.Create();
            }
        }
    }
}
