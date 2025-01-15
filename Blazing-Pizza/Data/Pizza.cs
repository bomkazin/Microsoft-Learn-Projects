namespace BlazingPizza.Data;

public class PizzaService
{
    public Task<Pizza[]> GetPizzasAsync()
    {
    // Call your data access technology here
    return Task.FromResult(new Pizza[0]);
    }
}

//The class defines the pizza's properties and data types. 
//Make sure these properties match the pizza schema in the data source.

public class Pizza
{
    public int PizzaId {get; set; }

    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public decimal Price { get; set; }
    
    public bool Vegetarian { get; set; }
    
    public bool Vegan { get; set; }
}