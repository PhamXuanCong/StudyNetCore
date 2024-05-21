using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NWZWalks.Api.Data;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO;
using NWZWalks.Api.Repositories;

namespace NWZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;

        public RegionController( IRegionRepository regionRepository)
        {
            this.regionRepository = regionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //get region domain model from database
            var regions = await regionRepository.GetAllAsync();

            //Map Region domain model to region Dtos
            var regionsDto = new List<RegionDtos>();

            foreach (var region in regions)
            {
                regionsDto.Add(new RegionDtos()
                {
                    Id = region.Id,
                    Name = region.Name,
                    Code = region.Code,
                });
            }

            return Ok(regionsDto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var region = await regionRepository.GetById(id);

            if (region == null)
            {
                return NotFound();

            }

            var regionDtos = new RegionDtos()
            {
                Id = region.Id,
                Name = region.Name,
                Code = region.Code
            };

            return Ok(region);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddRegionDto regionDto)
        {
            var regionDomainModel = new Region()
            {
                Code = regionDto.Code,
                Name = regionDto.Name
            };

            var region =await regionRepository.Create(regionDomainModel);

            if (region == null)
                return NotFound();

            //map domain model back to DTO
            var regionDto1 = new RegionDtos()
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name
            };

            return CreatedAtAction(nameof(GetById), new { id = regionDto1.Id }, regionDto1);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateRegionDto regionDto)
        {
            var region = new Region()
            {
                Name = regionDto.Name,
                Code = regionDto.Code,
            };

            var regionDomainModel = await regionRepository.Update(id , region);

            if (regionDomainModel == null)
            {
                return NotFound();
            }

            //Map dto to domain model
            regionDomainModel.Name = regionDto.Name;

            //map domain model to dto
            var response = new RegionDtos()
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name
            };

            return Ok(response);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var regionModel = await regionRepository.Delete(id);

            if (regionModel == null)
                return NotFound();

            return Ok();
        }
    }
}
