using Newtonsoft.Json;

namespace Animals.Common.Entities;

/// <summary>
/// An abstract class that describes the Animal entity.
/// </summary>
public abstract class Animal
{
    private const string DEFAULT_NAME = "Animal";
    private const string DEFAULT_COLOR = "Gray";
    private const int DEFAULT_AGE = 1;

    private static int _animalsCount;

    /// <summary>
    /// Static constructor. Initializes _animalsCount field.
    /// </summary>
    static Animal()
    {
        _animalsCount = 0;
    }

    /// <summary>
    /// Protected primary constructor.
    /// </summary>
    protected Animal()
        : this(Guid.Empty, DEFAULT_NAME, DEFAULT_COLOR, DEFAULT_AGE)
    {
    }

    /// <summary>
    /// Protected full constructor.
    /// </summary>
    protected Animal(Guid id, string name, string color, int age)
    {
        Id = id;
        Name = name;
        Color = color;
        Age = age;

        RecordAnimalCreated();
    }

    /// <summary>
    /// Count of Animals created.
    /// </summary>
    public static int AnimalsCount => _animalsCount;

    /// <summary>
    /// The ID of the Animal.
    /// </summary>
    [JsonProperty(nameof(Id))]
    public Guid Id { get; protected set; }

    /// <summary>
    /// The Name of the Animal.
    /// </summary>
    [JsonProperty(nameof(Name))]
    public string Name { get; protected set; }

    /// <summary>
    /// The Color of the Animal.
    /// </summary>
    [JsonProperty(nameof(Color))]
    public string Color { get; protected set; }

    /// <summary>
    /// The Age of the Animal.
    /// </summary>
    [JsonProperty(nameof(Age))]
    public int Age { get; protected set; }

    /// <summary>
    /// A delegate for StartedMoving event.
    /// </summary>
    public delegate void StartedMovingHandler(Animal animal);

    /// <summary>
    /// A delegate for StoppedMoving event.
    /// </summary>
    public delegate void StoppedMovingHandler(Animal animal);

    /// <summary>
    /// An event that occurs when an animal starts moving.
    /// </summary>
    public event StartedMovingHandler StartedMoving;

    /// <summary>
    /// An event that occurs when an animal stops moving.
    /// </summary>
    public event StoppedMovingHandler StoppedMoving;

    /// <summary>
    /// Records that the Animal has been created.
    /// </summary>
    private static void RecordAnimalCreated()
    {
        _animalsCount++;
    }

    /// <summary>
    /// Ignores the record that the Animal was created. Used when copying an Animal.
    /// </summary>
    /// <param name="animal">The Animal to ignore record for.</param>
    /// <returns>The same Animal instance.</returns>
    public static T IgnoreCreatedRecording<T>(T animal) where T : Animal
    {
        _animalsCount--;
        return animal;
    }

    /// <summary>
    /// Changes the color of the Animal.
    /// </summary>
    /// <param name="value">The new color.</param>
    public virtual void Paint(string value)
    {
        Color = value;
    }

    /// <inheritdoc/>
    public override string ToString()
        => $"Animal({Id}): {Name}";
}
