namespace NestSecure.VisitorService.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Asynchronously retrieves all entities of type TEntity.
        /// </summary>
        /// <returns>A list of all entities of type TEntity.</returns>
        Task<List<TEntity>> GetAllAsync();

        /// <summary>
        /// Asynchronously retrieves an entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns>The entity with the specified ID.</returns>
        Task<TEntity> GetByIdAsync(int id);

        /// <summary>
        /// Asynchronously adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        /// <returns>A task representing the asynchronous add operation.</returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Asynchronously updates an existing entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A task representing the asynchronous update operation.</returns>
        Task UpdateAsync(TEntity entity);

        /// <summary>
        /// Asynchronously deletes an entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        /// <returns>A task representing the asynchronous delete operation.</returns>
        Task DeleteAsync(int id);
    }
}
