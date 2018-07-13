using Abstractions.CQRS;
using Airport.Contract.Command.Pilot;
using Airport.Contract.Command.Ticket;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Command
{
    public class CreateTicketCommandHandler : ICommandHandler<CreateTicketCommand>
    {
        private readonly TicketRepository _ticketRepository;
        private readonly IMapper _mapper;

        public CreateTicketCommandHandler(TicketRepository ticketRepository, IMapper mapper)
        {
            _ticketRepository = ticketRepository;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(CreateTicketCommand command)
        {
            if (await _ticketRepository.GetById(command.Id) != null)
            {
                throw new Exception("Ticket with same Id already exists");
            }

            var ticket = _mapper.Map<Airport.Domain.Entities.Ticket>(command);

            await _ticketRepository.Create(ticket);
        }
    }
}
