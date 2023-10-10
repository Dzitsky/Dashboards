using Dashboard.Contracts.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Application.AppServices.Contexts.Files.Repositories
{
    /// <summary>
    /// Репозиторий по работе с файлами.
    /// </summary>
    public interface IFileRepository
    {
        /// <summary>
        /// Загрузка файла.
        /// </summary>
        /// <param name="file">Файл.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Идентификатор загруженного файла.</returns>
        Task<Guid> UploadAsync(Domain.Files.File file, CancellationToken cancellationToken);

        /// <summary>
        /// Скачивание файла.
        /// </summary>
        /// <param name="id">Идентификатор файла.</param>
        /// <param name="cancellationToken">Токен отмены.</param>
        /// <returns>Файл.</returns>
        Task<FileDto> DownloadAsync(Guid id, CancellationToken cancellationToken);
    }
}
