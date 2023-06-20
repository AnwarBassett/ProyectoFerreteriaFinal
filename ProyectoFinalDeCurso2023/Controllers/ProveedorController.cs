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
    public class ProveedorController : ControllerBase
    {
        private readonly ILogger<ProveedorController> _logger;
        private readonly IProveedorRepository _proveedorRepo;
        private readonly IMapper _mapper;

        public ProveedorController(ILogger<ProveedorController> logger, IProveedorRepository proveedorRepo, IMapper mapper)
        {
            _logger = logger;
            _proveedorRepo = proveedorRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProveedorDto>>> GetProveedores()
        {
            _logger.LogInformation("Obtener los proveedores");

            var proveedorList = await _proveedorRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProveedorDto>>(proveedorList));
        }

        [HttpGet("{id:int}", Name = "GetProveedor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProveedorDto>> GetProveedor(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer proveedor con Id {id}");
                return BadRequest();
            }
            var proveedor = await _proveedorRepo.Get(p => p.IdProveedor == id);

            if (proveedor == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProveedorDto>(proveedor));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProveedorDto>> AddProveedor([FromBody] ProveedorCreateDto proveedorCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _proveedorRepo.Get(p => p.NombreProveedor.ToLower() == proveedorCreateDto.NombreProveedor.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Proveedor con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (proveedorCreateDto == null)
            {
                return BadRequest(proveedorCreateDto);
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorCreateDto);
            await _proveedorRepo.Add(modelo);

            return CreatedAtRoute("GetProveedor", new { id = modelo.IdProveedor }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProveedor(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var proveedor = await _proveedorRepo.Get(p => p.IdProveedor == id);

            if (proveedor == null)
            {
                return NotFound();
            }

            _proveedorRepo.Remove(proveedor);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProveedor(int id, [FromBody] ProveedorUpdateDto proveedorUpdateDto)
        {
            if (proveedorUpdateDto == null || id != proveedorUpdateDto.IdProveedor)
            {
                return BadRequest();
            }

            Proveedor modelo = _mapper.Map<Proveedor>(proveedorUpdateDto);

            _proveedorRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProveedor(int id, JsonPatchDocument<ProveedorUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var proveedor = await _proveedorRepo.Get(p => p.IdProveedor == id, tracked: false);

            ProveedorUpdateDto proveedorUpdateDto = _mapper.Map<ProveedorUpdateDto>(proveedor);

            if (proveedor == null) return BadRequest();

            patchDto.ApplyTo(proveedorUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Proveedor modelo = _mapper.Map<Proveedor>(proveedorUpdateDto);
            _proveedorRepo.Update(modelo);

            return NoContent();
        }
    }
}
