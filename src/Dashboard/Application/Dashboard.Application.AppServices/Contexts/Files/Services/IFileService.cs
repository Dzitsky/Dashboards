using Dashboard.Contracts.Files;

namespace Dashboard.Application.AppServices.Contexts.Files.Services
{
    /// <summary>
    /// Сервис по работе с файлами.
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Загрузка файла.
        /// </summary>
        /// <param name="file">Файл.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Идентификатор загруженного файла.</returns>
        Task<Guid> UploadAsync(FileDto file, CancellationToken cancellationToken);

        /// <summary>
        /// Скачивание файла.
        /// </summary>
        /// <param name="id">Идентификатор файла.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Файл.</returns>
        Task<FileDto> DownloadAsync(Guid id, CancellationToken cancellationToken);
    }
}
