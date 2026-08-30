using PrintKmBack.Repositories.Interfaces;
using PrintKmBack.Services.Interfaces;

namespace PrintKmBack.Services;

public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
{
    private readonly IGenericRepository<TEntity> _repository;

    public GenericService(IGenericRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return _repository.GetAllAsync();
    }

    public Task<TEntity?> GetByIdAsync(params object[] keyValues)
    {
        return _repository.GetByIdAsync(keyValues);
    }

    public Task<TEntity> CreateAsync(TEntity entity)
    {
        return _repository.CreateAsync(entity);
    }

    public Task<bool> UpdateAsync(TEntity entity, params object[] keyValues)
    {
        return _repository.UpdateAsync(entity, keyValues);
    }

    public Task<bool> DeleteAsync(params object[] keyValues)
    {
        return _repository.DeleteAsync(keyValues);
    }
}
