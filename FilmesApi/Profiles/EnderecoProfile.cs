using AutoMapper;
using FilmesApi.Data.Dtos.Endereco;
using FilmesApi.Models;
using FilmesAPI.Data.Dtos;

namespace FilmesApi.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();            
            CreateMap<Endereco, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Endereco>();
        }
    }
}
