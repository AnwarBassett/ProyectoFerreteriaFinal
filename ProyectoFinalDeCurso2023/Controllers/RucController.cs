using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Modelos.Dto;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RucController : ControllerBase
    {
        private readonly ILogger<RucController> _logger;
        private readonly IRucRepository _rucRepo;
        private readonly IMapper _mapper;

        public RucController(ILogger<RucController> logger, IRucRepository rucRepo, IMapper mapper)
        {
            _logger = logger;
            _rucRepo = rucRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<RucDto>>> GetRucs()
        {
            _logger.LogInformation("Obtener las rucs");

            var rucList = await _rucRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<RucDto>>(rucList));
        }

        [HttpGet("{id:int}", Name = "GetRuc")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RucDto>> GetRuc(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer ruc con Id {id}");
                return BadRequest();
            }
            var ruc = await _rucRepo.Get(r => r.IdRuc == id);

            if (ruc == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<RucDto>(ruc));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RucDto>> AddRuc([FromBody] RucCreateDto rucCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _rucRepo.Get(r => r.IdRuc == rucCreateDto.IdRuc) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Id con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (rucCreateDto == null)
            {
                return BadRequest(rucCreateDto);
            }

            Ruc modelo = _mapper.Map<Ruc>(rucCreateDto);
            await _rucRepo.Add(modelo);

            return CreatedAtRoute("GetRuc", new { id = modelo.IdRuc }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteRuc(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var ruc = await _rucRepo.Get(r => r.IdRuc == id);

            if (ruc == null)
            {
                return NotFound();
            }

            _rucRepo.Remove(ruc);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateRuc(int id, [FromBody] RucUpdateDto rucUpdateDto)
        {
            if (rucUpdateDto == null || id != rucUpdateDto.IdRuc)
            {
                return BadRequest();
            }

            Ruc modelo = _mapper.Map<Ruc>(rucUpdateDto);

            _rucRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialRuc(int id, JsonPatchDocument<RucUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var ruc = await _rucRepo.Get(r => r.IdRuc == id, tracked: false);

            RucUpdateDto rucUpdateDto = _mapper.Map<RucUpdateDto>(ruc);

            if (ruc == null) return BadRequest();

            patchDto.ApplyTo(rucUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Ruc modelo = _mapper.Map<Ruc>(rucUpdateDto);
            _rucRepo.Update(modelo);

            return NoContent();
        }
    }
}
