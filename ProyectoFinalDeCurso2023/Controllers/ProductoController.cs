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
    public class ProductoController : ControllerBase
    {
        private readonly ILogger<ProductoController> _logger;
        private readonly IProductosRepository _productoRepo;
        private readonly IMapper _mapper;

        public ProductoController(ILogger<ProductoController> logger, IProductosRepository productoRepo, IMapper mapper)
        {
            _logger = logger;
            _productoRepo = productoRepo;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductosDto>>> GetProductos()
        {
            _logger.LogInformation("Obtener los productos");

            var productoList = await _productoRepo.GetAll();

            return Ok(_mapper.Map<IEnumerable<ProductosDto>>(productoList));
        }

        [HttpGet("{id:int}", Name = "GetProducto")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductosDto>> GetProducto(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer producto con Id {id}");
                return BadRequest();
            }
            var producto = await _productoRepo.Get(p => p.IdProducto == id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductosDto>(producto));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDto>> AddProducto([FromBody] ProductosCreateDto productoCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _productoRepo.Get(p => p.NombreProducto.ToLower() == productoCreateDto.NombreProducto.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El Producto con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (productoCreateDto == null)
            {
                return BadRequest(productoCreateDto);
            }

            Productos modelo = _mapper.Map<Productos>(productoCreateDto);
            await _productoRepo.Add(modelo);

            return CreatedAtRoute("GetProducto", new { id = modelo.IdProducto }, modelo);

        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteProducto(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var producto = await _productoRepo.Get(p => p.IdProducto == id);

            if (producto == null)
            {
                return NotFound();
            }

            _productoRepo.Remove(producto);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateProducto(int id, [FromBody] ProductosUpdateDto productosUpdateDto)
        {
            if (productosUpdateDto == null || id != productosUpdateDto.IdProducto)
            {
                return BadRequest();
            }

            Productos modelo = _mapper.Map<Productos>(productosUpdateDto);

            _productoRepo.Update(modelo);

            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialProducto(int id, JsonPatchDocument<ProductosUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var producto = await _productoRepo.Get(p => p.IdProducto == id, tracked: false);

            ProductosUpdateDto productosUpdateDto = _mapper.Map<ProductosUpdateDto>(producto);

            if (producto == null) return BadRequest();

            patchDto.ApplyTo(productosUpdateDto, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Productos modelo = _mapper.Map<Productos>(productosUpdateDto);
            _productoRepo.Update(modelo);

            return NoContent();
        }
    }
}
