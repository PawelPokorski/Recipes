namespace Recipes.Domain.Entities;

public class RecipeIngredient
{
    public int IngredientId { get; set; }
    public int RecipeId { get; set; }

    public string Group { get; set; } = string.Empty;
    public double Quantity { get; set; }
    public string Unit { get; set; } = string.Empty;
}