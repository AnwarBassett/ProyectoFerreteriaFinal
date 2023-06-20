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
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly IMapper _mapper;

        public UsuarioController(ILogger<UsuarioController> logger, IUsuarioRepository usuarioRepo, IMapper mapper)
        {
            _logger = logger;
            _usuarioRepo = usuarioRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarios()
        {
            _logger.LogInformation("Obtener los usuarios");

            var usuarioList = await _usuarioRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<UsuarioDto>>(usuarioList));
        }

        [HttpGet("{id:int}", Name = "GetUsuario")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> GetUsuario(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer usuario con Id {id}");
                return BadRequest();
            }
            var usuario = await _usuarioRepo.Get(u => u.IdUsuario == id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<UsuarioDto>(usuario));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioDto>> AddUsuario([FromBody] UsuarioCreateDto usuarioCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _usuarioRepo.Get(u => u.NombreCompleto.ToLower() == usuarioCreateDto.NombreCompleto.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Usuario con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (usuarioCreateDto == null)
            {
                return BadRequest(usuarioCreateDto);
            }

            Usuario modelo = _mapper.Map<Usuario>(usuarioCreateDto);
            await _usuarioRepo.Add(modelo);

            return CreatedAtRoute("GetUsuario", new { id = modelo.IdUsuario }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var usuario = await _usuarioRepo.Get(u => u.IdUsuario == id);

            if (usuario == null)
            {
                return NotFound();
            }

            _usuarioRepo.Remove(usuario);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUsuario(int id, [FromBody] UsuarioUpdateDto usuarioUpdateDto)
        {
            if (usuarioUpdateDto == null || id != usuarioUpdateDto.IdUsuario)
            {
                return BadRequest();
            }

            Usuario modelo = _mapper.Map<Usuario>(usuarioUpdateDto);

            _usuarioRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialUsuario(int id, JsonPatchDocument<UsuarioUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var usuario = await _usuarioRepo.Get(u => u.IdUsuario == id, tracked: false);

            UsuarioUpdateDto usuarioUpdateDto = _mapper.Map<UsuarioUpdateDto>(usuario);

            if (usuario == null) return BadRequest();

            patchDto.ApplyTo(usuarioUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Usuario modelo = _mapper.Map<Usuario>(usuarioUpdateDto);
            _usuarioRepo.Update(modelo);

            return NoContent();
        }

    }
}
