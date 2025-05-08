namespace Recipes.Domain.Entities;

public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public int CookingTime { get; set; }
    public int Servings { get; set; }

    public List<RecipeIngredient> Ingredients { get; set; } = [];

    public List<string> Instructions { get; set; } = [];
}