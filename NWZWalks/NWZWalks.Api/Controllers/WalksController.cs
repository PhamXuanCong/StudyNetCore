using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NWZWalks.Api.Models.Domain;
using NWZWalks.Api.Models.DTO.Walks;
using NWZWalks.Api.Repositories;

namespace NWZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IWalkRepository _iWalkRepository;
        private readonly IMapper mapper;

        public WalksController(IWalkRepository iWalkRepository, IMapper _mapper)
        {
            _iWalkRepository = iWalkRepository;
            mapper = _mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var walks =await _iWalkRepository.GetAllAsync();
            var walksdto = mapper.Map<List<WalkDtos>>(walks);

            return Ok(walksdto);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var walk = await _iWalkRepository.GetAsync(id);

            var walkDto = mapper.Map<WalkDtos>(walk);

            return Ok(walk);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddWalkDto walkDto)
        {
            var walkModel = new Walk()
            {
                Id = Guid.NewGuid(),
                Name = walkDto.Name,
                Length = walkDto.Length,
                RegionId = walkDto.RegionId,
                WalkDifficultyId = walkDto.WalkDifficultyId
            };

           var walkNew = await _iWalkRepository.Create(walkModel);

           if (walkNew == null)
               return NotFound();

           var walkDto1 = mapper.Map<WalkDtos>(walkNew);

            return Ok(walkDto1);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> Put([FromRoute] Guid id,[FromBody] UpdateWalkDto walkDto)
        {
            var walkModel = mapper.Map<Walk>(walkDto);
            

            var walk = _iWalkRepository.UpdateAsync(id, walkModel);

            return Ok(walk);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var walk = _iWalkRepository.DeleteAsync(id);

            return  Ok(walk);
        }
    }
}
