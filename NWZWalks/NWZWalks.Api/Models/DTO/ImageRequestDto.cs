﻿using System.ComponentModel.DataAnnotations;

namespace NWZWalks.Api.Models.DTO
{
    public class ImageRequestDto
    {
        [Required]
        public IFormFile File { get; set; }

        [Required] public string FileName { get; set; }

        public string? FileDescription { get; set; }
    }
}
