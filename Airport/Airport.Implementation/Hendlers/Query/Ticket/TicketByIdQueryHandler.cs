using Abstractions.CQRS;
using Airport.Contract.Query.Ticket;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Ticket
{
    public class TicketByIdQueryHandler : IQueryHandler<TicketByIdQuery, TicketByIdResponse>
    {
        private readonly TicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public TicketByIdQueryHandler(TicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task<TicketByIdResponse> ExecuteAsync(TicketByIdQuery request)
        {
            var ticket = await _ticketRepository.GetById(request.TicketId);

            if (ticket == null)
            {
                throw new Exception("Ticket not found");
            }

            var mappedTicket = _mapper.Map<TicketByIdResponse>(ticket);

            return mappedTicket;
        }
    }
}
