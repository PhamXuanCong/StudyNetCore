using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);

    }
}
