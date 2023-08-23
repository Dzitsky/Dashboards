using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts;

/// <summary>
/// Объявление.
/// </summary>
public class PostDto : BaseDto
{
    /// <summary>
    /// Заголовок.
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Наименование категории.
    /// </summary>
    public string CategoryName { get; set; }
    
    /// <summary>
    /// Наименование тегов.
    /// </summary>
    public string[] TagNames { get; set; }
    
    /// <summary>
    /// Изображения.
    /// </summary>
    public IReadOnlyCollection<AttachmentDto> Attachments { get; set; }
    
    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }
    
}