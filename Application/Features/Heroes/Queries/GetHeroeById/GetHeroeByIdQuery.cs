using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interface;
using Application.Wrappers;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Heroes.Queries.GetHeroeById
{
    public class GetHeroeByIdQuery : IRequest<Response<HeroeDTO>>
    {
        public int Id { get; set; }
        public class GetHeroeByIdQueryHandler : IRequestHandler<GetHeroeByIdQuery, Response<HeroeDTO>>
        {
            private readonly IRepositoryAsync<Heroe> _heroeRepository;
            private readonly IMapper _mapper;

            public GetHeroeByIdQueryHandler(IRepositoryAsync<Heroe> heroeRepository, IMapper mapper)
            {
                _heroeRepository = heroeRepository;
                _mapper = mapper;
            }


            public async Task<Response<HeroeDTO>> Handle(GetHeroeByIdQuery query, CancellationToken cancellationToken)
            {
                var Heroe = await _heroeRepository.GetByIdAsync(query.Id);
                
                if (Heroe == null)
                {
                    throw new KeyNotFoundException($"Heroe con la Id {query.Id}.");
                }
                else
                {
                    var hero = _mapper.Map<HeroeDTO>(Heroe);
                    return new Response<HeroeDTO>(hero);
                }


       
            }
        }   
    }
}
