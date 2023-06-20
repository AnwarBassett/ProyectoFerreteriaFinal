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
    public class  ClienteController : ControllerBase
    {
        private readonly ILogger<ClienteController> _logger;
        private readonly IClienteRepository _clienteRepo;
        private readonly IMapper _mapper;

        public ClienteController(ILogger<ClienteController> logger, IClienteRepository clienteRepo, IMapper mapper)
        {
            _logger = logger;
            _clienteRepo = clienteRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClientes()
        {
            _logger.LogInformation("Obtener los clientes");

            var clienteList = await _clienteRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ClienteDto>>(clienteList));
        }

        [HttpGet("{id:int}", Name = "GetCliente")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteDto>> GetCliente(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer Cliente con Id {id}");
                return BadRequest();
            }
            var cliente = await _clienteRepo.Get(c => c.IdCliente == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClienteDto>(cliente));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDto>> AddCliente([FromBody] ClienteCreateDto clienteCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _clienteRepo.Get(c => c.NombreCompleto.ToLower() == clienteCreateDto.NombreCompleto.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Cliente con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (clienteCreateDto == null)
            {
                return BadRequest(clienteCreateDto);
            }

            Cliente modelo = _mapper.Map<Cliente>(clienteCreateDto);
            await _clienteRepo.Add(modelo);

            return CreatedAtRoute("GetCliente", new { id = modelo.IdCliente }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var cliente = await _clienteRepo.Get(c => c.IdCliente == id);

            if (cliente == null)
            {
                return NotFound();
            }

            _clienteRepo.Remove(cliente);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCliente(int id, [FromBody] ClienteUpdateDto clienteUpdateDto)
        {
            if (clienteUpdateDto == null || id != clienteUpdateDto.IdCliente)
            {
                return BadRequest();
            }

            Cliente modelo = _mapper.Map<Cliente>(clienteUpdateDto);

            _clienteRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialCliente(int id, JsonPatchDocument<ClienteUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var cliente = await _clienteRepo.Get(c => c.IdCliente == id, tracked: false);

            ClienteUpdateDto clienteUpdateDto = _mapper.Map<ClienteUpdateDto>(cliente);

            if (cliente == null) return BadRequest();

            patchDto.ApplyTo(clienteUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Cliente modelo = _mapper.Map<Cliente>(clienteUpdateDto);
            _clienteRepo.Update(modelo);

            return NoContent();
        }
        
    }
}
