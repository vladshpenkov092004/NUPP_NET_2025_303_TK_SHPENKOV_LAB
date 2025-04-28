using Newtonsoft.Json;

namespace Animals.Common.Entities;

/// <summary>
/// A sealed class that describes the Dog entity.
/// </summary>
public sealed class Dog : Animal
{
    private const string DEFAULT_NAME = "Dog";
    private const string DEFAULT_COLOR = "Brown";
    private const int DEFAULT_AGE = 3;
    private const string DEFAULT_BREED = "Labrador";

    /// <summary>
    /// Primary constructor.
    /// </summary>
    public Dog()
        : this(Guid.Empty, DEFAULT_NAME, DEFAULT_AGE, DEFAULT_BREED)
    {
    }

    /// <summary>
    /// Full constructor.
    /// </summary>
    public Dog(Guid id, string name, int age, string breed)
        : base(id, name, DEFAULT_COLOR, age)
    {
        Breed = breed;
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    public Dog(Dog dog)
        : this(dog.Id, dog.Name, dog.Age, dog.Breed)
    {
    }

    /// <summary>
    /// The Breed of the Dog.
    /// </summary>
    [JsonProperty(nameof(Breed))]
    public string Breed { get; private set; }

    /// <summary>
    /// Changes the color of the Animal. Cannot change the color of the Dog.
    /// </summary>
    public override void Paint(string value)
    {
        throw new InvalidOperationException("You cannot paint the dog. Dogs should always be brown.");
    }
}
