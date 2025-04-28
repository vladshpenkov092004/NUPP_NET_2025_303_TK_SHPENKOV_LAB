using Newtonsoft.Json;

namespace Animals.Common.Entities;

/// <summary>
/// A sealed class that describes the Hare entity.
/// </summary>
public sealed class Hare : Animal
{
    private const string DEFAULT_NAME = "Hare";
    private const string DEFAULT_COLOR = "Gray";
    private const int DEFAULT_AGE = 1;
    private const double DEFAULT_JUMP_LENGTH = 2.5; // в метрах

    /// <summary>
    /// Primary constructor.
    /// </summary>
    public Hare()
        : this(Guid.Empty, DEFAULT_NAME, DEFAULT_AGE, DEFAULT_JUMP_LENGTH)
    {
    }

    /// <summary>
    /// Full constructor.
    /// </summary>
    public Hare(Guid id, string name, int age, double jumpLength)
        : base(id, name, DEFAULT_COLOR, age)
    {
        JumpLength = jumpLength;
    }

    /// <summary>
    /// Copy constructor.
    /// </summary>
    public Hare(Hare hare)
        : this(hare.Id, hare.Name, hare.Age, hare.JumpLength)
    {
    }

    /// <summary>
    /// Average jump length in meters.
    /// </summary>
    [JsonProperty(nameof(JumpLength))]
    public double JumpLength { get; private set; }

    /// <summary>
    /// Changes the color of the Animal. Cannot change the color of the Hare.
    /// </summary>
    public override void Paint(string value)
    {
        throw new InvalidOperationException("You cannot paint the hare. Hares should always be gray.");
    }
}
