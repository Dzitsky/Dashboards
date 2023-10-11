using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Infrastructure.Repository;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

/// <inheritdoc cref="IPostRepository"/>
public class PostRepository : IPostRepository
{
    private readonly IRepository<Domain.Posts.Post> _repository;

    public PostRepository(IRepository<Domain.Posts.Post> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> CreateAsync(Domain.Posts.Post model, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(model);
        return model.Id;
    }

    public Task<Domain.Posts.Post> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _repository.GetByIdAsync(id, cancellationToken);
    }
}