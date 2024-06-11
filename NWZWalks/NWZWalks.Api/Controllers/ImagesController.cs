using Microsoft.AspNetCore.Mvc;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO;
using NWZWalks.Api.Repositories;

namespace NWZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }

        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageRequestDto request)
        {
            ValidateFileUpload(request);

            if (ModelState.IsValid)
            {
                var imageDomainModel = new Image
                {
                    File = request.File,
                    FileExtension = Path.GetExtension(request.File.FileName),
                    FileSizeBytes = request.File.Length,
                    FileDescription = request.FileDescription,
                    FileName = request.FileName
                };

                await _imageRepository.Upload(imageDomainModel);

                return Ok(imageDomainModel);
            }

            return  BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageRequestDto request)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };

            if (!allowedExtensions.Contains(Path.GetExtension(request.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsuported file extension");
                ;
            }

            if (request.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more than 10MB, please upload a smaller size file");

            }
        }
    }
}
