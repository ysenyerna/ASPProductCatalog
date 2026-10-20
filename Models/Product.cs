using System.ComponentModel.DataAnnotations;

public class Product
{ 
	public int Id { get; set; } 
	[Required] required public string Name { get; set; } 
	[Range(0.01, 1000)] public decimal Price { get; set; } 

}