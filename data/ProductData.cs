using System.Text.Json;

public static class ProductData
{
	private const string filePath = "data/products.json";

    public static void AddProduct(Product product)
	{
		List<Product> products = GetProducts();

		product.Id = products.Count;

		products.Add(product);

		string json = JsonSerializer.Serialize(
			products,
			new JsonSerializerOptions { WriteIndented = true });

		File.WriteAllText(filePath, json);
	}

	public static List<Product> GetProducts()
	{
		if (!File.Exists(filePath))
			return new List<Product>();

		string json = File.ReadAllText(filePath);

		return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
	}

	public static Product? GetProduct(int id)
	{
		return GetProducts().FirstOrDefault(p => p.Id == id);
	}
}