namespace ConsoleApp1;

public abstract class Program
{
	static void Main(string[] args)
	{
		Product p = new();
		ProductList list = new();
		
		list.Added += OnAddProduct;
		list.Updated += OnUpdateProduct;
		list.Deleted += OnDeleteProduct;

		Product pro1 = new Product(1, "DELL", 2, 349);
		Product pro2 = new Product(2, "MSI", 3, 699);

		list.Add(pro1);
		list.Add(pro2);
		
		PrintProducts(list, p);

		list.Update(1, newName: "DELL XPS", newQty: 4, newPrice: 499);
		
		PrintProducts(list, p);

		list.Delete(2);
		
		PrintProducts(list, p);
	}

	static void PrintProducts(ProductList list, Product p)
	{
		if (list.Products.Count == 0)
		{
			Console.WriteLine("There are no products in the list!");
			return;
		}
		
		Console.WriteLine(p.Header);
		foreach (var s in list.Products)
		{
			Console.WriteLine(s.Info);
		}
	}

	static void OnAddProduct(Object? sender, Product prd)
	{
		Console.WriteLine("Product Added");
	}

	static void OnUpdateProduct(Object? sender, Product prd)
	{
		Console.WriteLine($"Product Updated: {prd.Name}");
	}

	static void OnDeleteProduct(Object? sender, Product prd)
	{
		Console.WriteLine($"Product Deleted: {prd.Name}");
	}
}