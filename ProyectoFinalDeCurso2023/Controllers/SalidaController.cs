using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FerreteriaWEB.Data;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Modelos.Dto;
using Newtonsoft.Json;
using FerreteriaWEB.Repository.IRepository;

namespace FerreteriaWEB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalidaController : ControllerBase
    {
        private readonly ILogger<SalidaController> _logger;
        private readonly ISalidasRepository _salidasRepo;
        private readonly IMapper _mapper;

        public SalidaController(ILogger<SalidaController> logger, ISalidasRepository salidasRepo, IMapper mapper)
        {
            _logger = logger;
            _salidasRepo = salidasRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<SalidaDto>>> GetSalidas()
        {
            _logger.LogInformation("Obtener las salidas");

            var salidaList = await _salidasRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<SalidaDto>>(salidaList));
        }

        [HttpGet("{id:int}", Name = "GetSalidas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<SalidaDto>> GetSalida(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer salida con Id {id}");
                return BadRequest();
            }
            var salida = await _salidasRepo.Get(s => s.IdFactura == id);

            if (salida == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<SalidaDto>(salida));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<SalidaDto>> AddSalida([FromBody] SalidaCreateDto salidaCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _salidasRepo.Get(s => s.IdFactura == salidaCreateDto.IdFactura) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡La salida con ese id ya existe!");
                return BadRequest(ModelState);
            }

            if (salidaCreateDto == null)
            {
                return BadRequest(salidaCreateDto);
            }

            Salidas modelo = _mapper.Map<Salidas>(salidaCreateDto);
            await _salidasRepo.Add(modelo);

            return CreatedAtRoute("GetSalidas", new { id = modelo.IdFactura }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteSalida(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var salida = await _salidasRepo.Get(s => s.IdFactura == id);

            if (salida == null)
            {
                return NotFound();
            }

            _salidasRepo.Remove(salida);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateSalida(int id, [FromBody] SalidaUpdateDto salidaUpdateDto)
        {
            if (salidaUpdateDto == null || id != salidaUpdateDto.IdFactura)
            {
                return BadRequest();
            }

            Salidas modelo = _mapper.Map<Salidas>(salidaUpdateDto);

            _salidasRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialSalida(int id, JsonPatchDocument<SalidaUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var salida = await _salidasRepo.Get(s => s.IdFactura == id, tracked: false);

            SalidaUpdateDto salidaUpdateDto = _mapper.Map<SalidaUpdateDto>(salida);

            if (salida == null) return BadRequest();

            patchDto.ApplyTo(salidaUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Salidas modelo = _mapper.Map<Salidas>(salidaUpdateDto);
            _salidasRepo.Update(modelo);

            return NoContent();
        }

    }
}
