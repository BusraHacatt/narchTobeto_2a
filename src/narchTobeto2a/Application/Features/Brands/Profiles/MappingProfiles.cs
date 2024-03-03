using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Queries.GetList;
using Application.Features.Cars.Commands.Create;
using Application.Features.Cars.Queries.GetList;
using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries.GetList;
using Application.Features.Transmissions.Commands.Create;
using Application.Features.Transmissions.Queries.GetList;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Brands.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();
        CreateMap<Brand, GetListBrandItemDto>().ReverseMap();
        CreateMap<IPaginate<Brand>, GetListResponse<GetListBrandItemDto>>().ReverseMap();


        CreateMap<Fuel, CreateFuelCommand>().ReverseMap();
        CreateMap<Fuel, CreatedFuelResponse>().ReverseMap();
        CreateMap<Fuel, GetListFuelItemDto>().ReverseMap();
        CreateMap<IPaginate<Fuel>, GetListResponse<GetListFuelItemDto>>().ReverseMap();

        CreateMap<Transmission, CreateTransmissionCommand>().ReverseMap();
        CreateMap<Transmission, CreatedTransmissionResponse>().ReverseMap();
        CreateMap<Transmission, GetListTransmissionItemDto>().ReverseMap();
        CreateMap<IPaginate<Transmission>, GetListResponse<GetListTransmissionItemDto>>().ReverseMap();

        CreateMap<Car, CreateCarCommand>().ReverseMap();
        CreateMap<Car, CreatedCarResponse>().ReverseMap();
        CreateMap<Car, GetListCarItemDto>().ReverseMap();
        CreateMap<IPaginate<Car>, GetListResponse<GetListCarItemDto>>().ReverseMap();
    }
}