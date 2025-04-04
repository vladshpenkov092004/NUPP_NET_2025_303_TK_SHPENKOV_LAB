using Newtonsoft.Json;

namespace Animals.Common.Entities;

/// <summary>
/// A sealed class that describes the Bear entity.
/// </summary>
public sealed class Bear : Animal
{
    private const string DEFAULT_NAME = "Bear";
    private const string DEFAULT_COLOR = "Brown";
    private const int DEFAULT_AGE = 5;
    private const string DEFAULT_HABITAT = "Forest";

    /// <summary>
    /// Primary constructor.
    /// </summary>
    public Bear()
        : this(Guid.Empty, DEFAULT_NAME, DEFAULT_AGE, DEFAULT_HABITAT)
    {
    }

    /// <summary>
    /// Full constructor.
    /// </summary>
    public Bear(Guid id, string name, int age, string habitat)
        : base(id, name, DEFAULT_COLOR, age)
    {
        Habitat = habitat;
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    public Bear(Bear bear)
        : this(bear.Id, bear.Name, bear.Age, bear.Habitat)
    {
    }

    /// <summary>
    /// The natural habitat of the Bear.
    /// </summary>
    [JsonProperty(nameof(Habitat))]
    public string Habitat { get; private set; }

    /// <summary>
    /// Changes the color of the Animal. Cannot change the color of the Bear.
    /// </summary>
    public override void Paint(string value)
    {
        throw new InvalidOperationException("You cannot paint the bear. Bears should always be brown.");
    }
}
