using AutoMapper;
//using FerreteriaWEB.Migrations;
using FerreteriaWEB.Modelos;
using FerreteriaWEB.Modelos.Dto;

namespace FerreteriaWEB
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        {
            //Cliente
            CreateMap<Cliente, ClienteDto>();
            CreateMap<ClienteDto, Cliente>();

            CreateMap<Cliente, ClienteCreateDto>().ReverseMap();
            CreateMap<Cliente, ClienteUpdateDto>().ReverseMap();

            //Productos

            CreateMap<Productos, ProductosDto>();
            CreateMap<ProductosDto, Productos>();

            CreateMap<Productos, ProductosCreateDto>().ReverseMap();
            CreateMap<Productos, ProductosUpdateDto>().ReverseMap();

            //Proveedor

            CreateMap<Proveedor, ProveedorDto>();
            CreateMap<ProveedorDto, Proveedor>();

            CreateMap<Proveedor, ProveedorCreateDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorUpdateDto>().ReverseMap();

            //Salidas

            CreateMap<Salidas, SalidaDto>();
            CreateMap<SalidaDto, Salidas>();

            CreateMap<Salidas, SalidaCreateDto>().ReverseMap();
            CreateMap<Salidas, SalidaUpdateDto>().ReverseMap();

            CreateMap<SalidaDetalle, SalidaDetalleDto>().ReverseMap();
            CreateMap<SalidaDetalle, SalidaDetalleCreateDto>().ReverseMap();
            CreateMap<SalidaDetalle, SalidaDetalleUpdateDto>().ReverseMap();
            //Usuario

            CreateMap<Usuario, UsuarioDto>();
            CreateMap<UsuarioDto, Usuario>();

            CreateMap<Usuario, UsuarioCreateDto>().ReverseMap();
            CreateMap<Usuario, UsuarioUpdateDto>().ReverseMap();

            //Ruc

            CreateMap<Ruc, RucDto>();
            CreateMap<RucDto, Ruc>();

            CreateMap<Ruc, RucCreateDto>().ReverseMap();
            CreateMap<Ruc, RucUpdateDto>().ReverseMap();

        }

    }
}
