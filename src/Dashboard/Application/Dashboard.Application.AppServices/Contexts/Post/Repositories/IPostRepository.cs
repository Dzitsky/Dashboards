using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Post.Repositories;

/// <summary>
/// Репозиторий для работы с объявлениями.
/// </summary>
public interface IPostRepository
{
    /// <summary>
    /// Возвращает объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostDto"/></returns>
    Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}