using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

public class PostRepository : IPostRepository
{
    public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PostDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовое объявление",
            Description = "Описание.",
            CategoryName = "Книги",
            TagNames = new []{"фентези","ЛитРПГ"},
            Price = 500.43M
            
        }, cancellationToken);
    }
}