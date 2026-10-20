using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	[HttpGet]
	public IActionResult Create()
	{
		return View();
	}

	[HttpPost]
	public IActionResult Create(Product product)
	{
		if (!ModelState.IsValid)
		{
			return View(product);
		}

		ProductData.AddProduct(product);

		return RedirectToAction(nameof(Index));
	}
}