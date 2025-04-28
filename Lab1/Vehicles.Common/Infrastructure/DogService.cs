using Animals.Common.Entities;

namespace Animals.Common.Infrastructure;

/// <summary>
/// An in-memory implementation of CRUD service for the <see cref="Dog"/> entity.
/// </summary>
public sealed class DogService : CrudService<Dog>
{
    /// <summary>
    /// Gets the unique identifier from the specified <see cref="Dog"/> entity.
    /// </summary>
    /// <param name="entity">The dog entity.</param>
    /// <returns>The unique identifier of the dog.</returns>
    protected override Guid GetIdFromEntity(Dog entity)
        => entity.Id;

    /// <summary>
    /// Creates a deep copy of the specified <see cref="Dog"/> entity.
    /// </summary>
    /// <param name="entity">The dog to copy.</param>
    /// <returns>A new <see cref="Dog"/> instance copied from the original.</returns>
    protected override Dog CopyEntity(Dog entity)
        => new Dog(entity);
}
