namespace ConsoleApp1;

public class Product()
{
	private const int IdWidthField = -8;
	private const int NameWidthField = -20;
	private const int QuantityWidthField = 8;
	private const int PriceWidthField = 8;
	private const int TotalWidthField = 10;
	
	public int Id { get; set; }
	public string? Name { get; set; }
	public int Quantity { get; set; }
	public double Price { get; set; }

	public Product(int id, string? name, int qty, double price) : this()
	{
		Id = id;
		Name = name;
		Quantity = qty;
		Price = price;
	}

	private double GetTotal => Price * Quantity;

	public string Info => $"{Id, IdWidthField} {Name, NameWidthField} {Quantity, QuantityWidthField} {Price + "$", PriceWidthField} {GetTotal + "$", TotalWidthField}";

	public string Header => $"{"ID", IdWidthField} {"Name", NameWidthField} {"Quantity", QuantityWidthField} {"Price", PriceWidthField} {"Total",TotalWidthField}";
}