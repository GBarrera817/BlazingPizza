namespace BlazingPizza.Data;

public class PizzaService
{

    public Task<Pizza[]> GetPizzasAsync()
    {
        // call your data access technology here

        var pizzas = new List<Pizza> {
            new Pizza { Name = "The Baconatorizor", Description = "It has EVERY kind of bacon", Price =  11.99M, Vegetarian = false, Vegan = false },
            new Pizza { Name = "Buffalo chicken", Description = "Spicy chicken, hot sauce, and blue cheese, guaranteed to warm you up", Price = 12.75M, Vegetarian = false, Vegan = false },
            new Pizza { Name = "Veggie Delight", Description = "It's like salad, but on a pizza", Price =  11.5M, Vegetarian = false, Vegan = false },
            new Pizza { Name = "Margherita", Description = "Traditional Italian pizza with tomatoes and basil", Price =  9.99M, Vegetarian = false, Vegan = false },
            new Pizza { Name = "Basic Cheese Pizza", Description = "It's cheesy and delicious. Why wouldn't you want one?", Price =  11.99M, Vegetarian = false, Vegan = false },
            new Pizza { Name = "Classic pepperoni", Description = "It's the pizza you grew up with, but Blazing hot!", Price =  10.5M, Vegetarian = false, Vegan = false } 
        };

        return Task.FromResult(pizzas.ToArray());
    }
}
