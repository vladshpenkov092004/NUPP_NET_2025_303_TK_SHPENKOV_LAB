using Animals.Common.Entities;

namespace Animals.Common.Infrastructure;

/// <summary>
/// An in-memory implementation of CRUD service for the <see cref="Bear"/> entity.
/// </summary>
public sealed class BearService : CrudService<Bear>
{
    /// <summary>
    /// Gets the unique identifier from the specified <see cref="Bear"/> entity.
    /// </summary>
    /// <param name="entity">The bear entity.</param>
    /// <returns>The unique identifier of the bear.</returns>
    protected override Guid GetIdFromEntity(Bear entity)
        => entity.Id;

    /// <summary>
    /// Creates a deep copy of the specified <see cref="Bear"/> entity.
    /// </summary>
    /// <param name="entity">The bear to copy.</param>
    /// <returns>A new <see cref="Bear"/> instance copied from the original.</returns>
    protected override Bear CopyEntity(Bear entity) 
        => new Bear(entity);
}
