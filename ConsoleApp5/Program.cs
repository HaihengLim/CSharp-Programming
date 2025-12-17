using System.Runtime.CompilerServices;
using ProductLibrary;

namespace ConsoleApp5;

public abstract class Program
{
	static void Main(string[] args)
	{
		ProductList list = new();
		Product p = new Product();
		
		list.Created += (s, prd) => Console.WriteLine(
			$"Product Created:\n" +
			$"Id: {prd.Id}\n" +
			$"Name: {prd.Name}\n" +
			$"Quantity: {prd.Quantity}\n" +
			$"Price: {prd.Price.ToString("F2")}$\n" +
			$"Total: {prd.Total().ToString("F2")}$\n");
		list.Readed += (s, prd) => Console.WriteLine("Product Read!");
		list.Updated += (s, prd) => Console.WriteLine(
			$"Product with Id {prd.Id} update to\n" +
			$"newName: {prd.Name}\n" +
			$"newQuantity: {prd.Quantity}\n" +
			$"newPrice: {prd.Price.ToString("F2")}$\n" +
			$"newTotal: {prd.Total().ToString("F2")}$\n");
		list.Deleted += (s, prd) => Console.WriteLine($"Product Id: {prd.Id} deleted!");

		list.Initialize("Product.txt");
		list.Read(p);
		PrintProduct(list);

		list.Create(new Product(6, "Lenovo", 4, 349.99));
		list.Read(p);
		PrintProduct(list);

		list.Update(6, "Lenovo", 3, 499.99);
		list.Read(p);
		PrintProduct(list);

		list.Delete(3);
		list.Delete(2);

		list.Read(p);
		PrintProduct(list);
	}

	static void PrintProduct(ProductList prdList)
	{
		Product pro = new Product();
		Console.WriteLine(pro.Header);
		foreach (var p in prdList.Products)
		{
			Console.WriteLine(p.Info);
		}
	}
}