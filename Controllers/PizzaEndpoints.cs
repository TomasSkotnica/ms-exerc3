using ContosoPizza.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace exerc3.Controllers;

public static class PizzaEndpoints
{
    public static void MapPizzaEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Pizza").WithTags(nameof(Pizza));

        group.MapGet("/", () =>
        {
            return new [] { new Pizza() };
        })
        .WithName("GetAllPizzas")
        .WithOpenApi();

        group.MapGet("/{id}", (int id) =>
        {
            //return new Pizza { ID = id };
        })
        .WithName("GetPizzaById")
        .WithOpenApi();

        group.MapPut("/{id}", (int id, Pizza input) =>
        {
            return TypedResults.NoContent();
        })
        .WithName("UpdatePizza")
        .WithOpenApi();

        group.MapPost("/", (Pizza model) =>
        {
            //return TypedResults.Created($"/api/Pizzas/{model.ID}", model);
        })
        .WithName("CreatePizza")
        .WithOpenApi();

        group.MapDelete("/{id}", (int id) =>
        {
            //return TypedResults.Ok(new Pizza { ID = id });
        })
        .WithName("DeletePizza")
        .WithOpenApi();
    }
}
