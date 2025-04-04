using Newtonsoft.Json;

namespace Animals.Common.Entities;

/// <summary>
/// A sealed class that describes the Cat entity.
/// </summary>
public sealed class Cat : Animal
{
    private const string DEFAULT_NAME = "Cat";
    private const string DEFAULT_COLOR = "White";
    private const int DEFAULT_AGE = 2;
    private const string DEFAULT_FAVORITE_FOOD = "Fish";

    /// <summary>
    /// Primary constructor.
    /// </summary>
    public Cat()
        : this(Guid.Empty, DEFAULT_NAME, DEFAULT_AGE, DEFAULT_FAVORITE_FOOD)
    {
    }

    /// <summary>
    /// Full constructor.
    /// </summary>
    public Cat(Guid id, string name, int age, string favoriteFood)
        : base(id, name, DEFAULT_COLOR, age)
    {
        FavoriteFood = favoriteFood;
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    public Cat(Cat cat)
        : this(cat.Id, cat.Name, cat.Age, cat.FavoriteFood)
    {
    }

    /// <summary>
    /// The favorite food of the Cat.
    /// </summary>
    [JsonProperty(nameof(FavoriteFood))]
    public string FavoriteFood { get; private set; }

    /// <summary>
    /// Changes the color of the Animal. Cannot change the color of the Cat.
    /// </summary>
    public override void Paint(string value)
    {
        throw new InvalidOperationException("You cannot paint the cat. Cats should always be white.");
    }
}
