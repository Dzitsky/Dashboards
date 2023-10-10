using Dashboard.Application.AppServices.Contexts.Files.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Files;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Files.Repositories
{
    /// <inheritdoc cref="IFileRepository"/> 
    public class FileRepository : IFileRepository
    {
        private readonly IRepository<Domain.Files.File> _repository;

        public FileRepository(IRepository<Domain.Files.File> repository)
        {
            _repository = repository;
        }

        /// <inheritdoc/>
        public Task<FileDto> DownloadAsync(Guid id, CancellationToken cancellationToken)
        {
            return _repository.GetAll().Where(s => s.Id == id).Select(s => new FileDto
            {
                Content = s.Content,
                ContentType = s.ContentType,
                Name = s.Name
            }).FirstOrDefaultAsync(cancellationToken);
        }

        /// <inheritdoc/>
        public async Task<Guid> UploadAsync(Domain.Files.File file, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(file);
            return file.Id;
        }
    }
}
