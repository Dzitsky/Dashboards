using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Post;
using Dashboard.Infrastructure.Repository;

namespace Dashboard.Application.AppServices.Contexts.Post.Services;

/// <inheritdoc />
public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PostService"/>
    /// </summary>
    /// <param name="postRepository">Репозиторий для работы с объявлениями.</param>
    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    /// <inheritdoc />
    public Task<Domain.Posts.Post> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _postRepository.GetByIdAsync(id, cancellationToken);
    }

    /// <inheritdoc/>
    public Task<Guid> CreateAsync(CreatePostDto model, CancellationToken cancellationToken)
    {
        var post = new Domain.Posts.Post()
        {
            Description = model.Description,
            Price = model.Price,
            Title = model.Title,
            CategoryId = model.CategoryId,
            TagNames = model.TagNames,
        };
        return _postRepository.CreateAsync(post, cancellationToken);
    }
}