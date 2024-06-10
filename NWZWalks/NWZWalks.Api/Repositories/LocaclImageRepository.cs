using NWZWalks.Api.Data;
using NWZWalks.Api.Models.Domain;

namespace NWZWalks.Api.Repositories
{
    public class LocaclImageRepository : IImageRepository
    {
        private readonly IWebHostEnvironment _iWebHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly NZWalksDbContext _dbContext;

        public LocaclImageRepository(IWebHostEnvironment iWebHostEnvironment, IHttpContextAccessor httpContextAccessor, NZWalksDbContext dbContext)
        {
            _iWebHostEnvironment = iWebHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
        }

        public async Task<Image> Upload(Image image)
        {
            var localFilePath = Path.Combine(_iWebHostEnvironment.ContentRootPath, "Images", image.FileName,
                image.FileExtension);

            using var stream = new FileStream(localFilePath, FileMode.Create);

            await image.File.CopyToAsync(stream);

            var urlfilePath =
                $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}{_httpContextAccessor.HttpContext.Request.PathBase}/Images/{image.FileName}{image.FileExtension}";

            image.FilePath = urlfilePath;

            _dbContext.Images.AddAsync(image);
            _dbContext.SaveChangesAsync();

            return  image;
        }
    }
}
