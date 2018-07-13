using Abstractions.CQRS;
using Airport.Contract.Query.AirCraft;
using Airport.Contract.Query.Ticket;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.AirCraft
{
    public class TicketsQueryHandler : IQueryHandler<TicketsQuery, TicketsResponse>
    {
        private readonly AirCraftRepository _airCraftRepository;
        private readonly IMapper _mapper;

        public TicketsQueryHandler(AirCraftRepository airCraftRepository, IMapper mapper)
        {
            _airCraftRepository = airCraftRepository;
            _mapper = mapper;
        }

        public async Task<TicketsResponse> ExecuteAsync(TicketsQuery request)
        {
            var tickets = _airCraftRepository.GetAll();

            if (tickets == null)
            {
                throw new Exception("Tickets not found");
            }

            var mappedAirCraft = _mapper.Map<TicketsResponse>(tickets);

            return mappedAirCraft;
        }
    }
}
