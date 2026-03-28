namespace ConsoleApp1;

public class ProductList
{
	public List<Product> Products { get; } = new();
	public event EventHandler<Product>? Added;
	public event EventHandler<Product>? Updated;
	public event EventHandler<Product>? Deleted;

	public bool Add(Product? prd)
	{
		if (prd == null) return false;
		if (!IsProductIdValid(prd.Id)) return false;
		if (IsProductNameValid(prd.Name)) return false;
		if (!IsProductQuantityValid(prd.Quantity)) return false;
		if (!IsProductPriceValid(prd.Price)) return false;
		
		Products.Add(prd);
		Added?.Invoke(this, prd);
		return true;
	}

	public bool Update(int id, string? newName = null, int? newQty = null, double? newPrice = null)
	{
		var product = Products.FirstOrDefault(p => p.Id == id);
		if (product == null) return false;

		if (newName != null && !IsProductNameValid(newName)) product.Name = newName;
		if (newQty.HasValue && IsProductQuantityValid(newQty.Value)) product.Quantity = newQty.Value;
		if (newPrice.HasValue && IsProductPriceValid(newPrice.Value)) product.Price = newPrice.Value;
		
		Updated?.Invoke(this, product);
		return true;
	}

	public bool Delete(int id)
	{
		var product = Products.FirstOrDefault(p => p.Id == id);
		if (product == null) return false;

		Products.Remove(product);
		Deleted?.Invoke(this, product);
		return true;
	}
	
	private bool IsProductIdValid(int id)
	{
		return id >= 0;
	}

	private bool IsProductNameValid(string? name)
	{
		return string.IsNullOrEmpty(name);
	}

	private bool IsProductQuantityValid(int qty)
	{
		return qty >= 0;
	}

	private bool IsProductPriceValid(double price)
	{
		return price >= 0;
	}
}