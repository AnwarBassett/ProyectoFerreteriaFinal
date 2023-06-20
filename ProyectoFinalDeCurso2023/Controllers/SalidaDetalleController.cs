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
    public class SalidaDetalleController : ControllerBase
    {
        private readonly ILogger<SalidaDetalleController> _logger;
        private readonly ISalidaDetalleRepository _salidaDetRepo;
        private readonly IMapper _mapper;

        public SalidaDetalleController(ILogger<SalidaDetalleController> logger, ISalidaDetalleRepository salidaDetRepo, IMapper mapper)
        {
            _logger = logger;
            _salidaDetRepo = salidaDetRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<SalidaDetalleDto>>> GetSalidasDet()
        {
            _logger.LogInformation("Obtener las salidas detalladas");

            var salidaDetList = await _salidaDetRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<SalidaDetalleDto>>(salidaDetList));
        }

        [HttpGet("{id:int}", Name = "GetSalidaDet")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SalidaDetalleDto>> GetSalidaDet(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer los detalles de la salida con Id {id}");
                return BadRequest();
            }
            var salidaDet = await _salidaDetRepo.Get(s => s.Id == id);

            if (salidaDet == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<SalidaDetalleDto>(salidaDet));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SalidaDetalleDto>> AddSalidaDet([FromBody] SalidaDetalleCreateDto salidaDetalleCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _salidaDetRepo.Get(s => s.Id == salidaDetalleCreateDto.Id) != null)
            {
                ModelState.AddModelError("IdExiste", "¡El Producto con ese Id ya existe!");
                return BadRequest(ModelState);
            }

            if (salidaDetalleCreateDto == null)
            {
                return BadRequest(salidaDetalleCreateDto);
            }

            SalidaDetalle modelo = _mapper.Map<SalidaDetalle>(salidaDetalleCreateDto);
            await _salidaDetRepo.Add(modelo);

            return CreatedAtRoute("GetSalidaDet", new { id = modelo.Id }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteSalidaDet(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var salidaDet = await _salidaDetRepo.Get(s => s.Id == id);

            if (salidaDet == null)
            {
                return NotFound();
            }

            _salidaDetRepo.Remove(salidaDet);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateSalidaDet(int id, [FromBody] SalidaDetalleUpdateDto salidaDetalleUpdateDto)
        {
            if (salidaDetalleUpdateDto == null || id != salidaDetalleUpdateDto.Id)
            {
                return BadRequest();
            }

            SalidaDetalle modelo = _mapper.Map<SalidaDetalle>(salidaDetalleUpdateDto);

            _salidaDetRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialSalidaDet(int id, JsonPatchDocument<SalidaDetalleUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var salidaDet = await _salidaDetRepo.Get(s => s.Id == id, tracked: false);

            SalidaDetalleUpdateDto salidaDetalleUpdateDto = _mapper.Map<SalidaDetalleUpdateDto>(salidaDet);

            if (salidaDet == null) return BadRequest();

            patchDto.ApplyTo(salidaDetalleUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            SalidaDetalle modelo = _mapper.Map<SalidaDetalle>(salidaDetalleUpdateDto);
            _salidaDetRepo.Update(modelo);

            return NoContent();
        }
    }
}
