using Dashboard.Application.AppServices.Contexts.Files.Repositories;
using Dashboard.Contracts.Files;

namespace Dashboard.Application.AppServices.Contexts.Files.Services
{
    /// <inheritdoc cref="IFileService"/>
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        
        /// <inheritdoc/>
        public Task<FileDto> DownloadAsync(Guid id, CancellationToken cancellationToken)
        {
            return _fileRepository.DownloadAsync(id, cancellationToken);
        }

        /// <inheritdoc/>
        public Task<Guid> UploadAsync(FileDto file, CancellationToken cancellationToken)
        {
            var entity = new Domain.Files.File
            {
                Name = file.Name,
                Content = file.Content,
                ContentType = file.ContentType,
                Created = DateTime.UtcNow,
                Length = file.Content.Length
            };

            return _fileRepository.UploadAsync(entity, cancellationToken);
        }
    }
}
