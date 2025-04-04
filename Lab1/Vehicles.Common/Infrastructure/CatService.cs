using Animals.Common.Entities;

namespace Animals.Common.Infrastructure;

/// <summary>
/// An in-memory implementation of CRUD service for the <see cref="Cat"/> entity.
/// </summary>
public sealed class CatService : CrudService<Cat>
{
    /// <summary>
    /// Gets the unique identifier from the specified <see cref="Cat"/> entity.
    /// </summary>
    /// <param name="entity">The cat entity.</param>
    /// <returns>The unique identifier of the cat.</returns>
    protected override Guid GetIdFromEntity(Cat entity)
        => entity.Id;

    /// <summary>
    /// Creates a deep copy of the specified <see cref="Cat"/> entity.
    /// </summary>
    /// <param name="entity">The cat to copy.</param>
    /// <returns>A new <see cref="Cat"/> instance copied from the original.</returns>
    protected override Cat CopyEntity(Cat entity)
        => new Cat(entity);
}

