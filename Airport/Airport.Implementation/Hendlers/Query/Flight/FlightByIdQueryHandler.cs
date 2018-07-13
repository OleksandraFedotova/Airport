﻿using Abstractions.CQRS;
using Airport.Contract.Query.Flight;
using AirPort.DataAccess;
using AutoMapper;
using System;
using System.Threading.Tasks;

namespace Airport.Implementation.Hendlers.Query.Flight
{
    public class FlightByIdQueryHandler : IQueryHandler<FlightByIdQuery, FlightByIdResponse>
    {
        private readonly FlightRepository _flightRepository;
        private readonly IMapper _mapper;

        public FlightByIdQueryHandler(FlightRepository flightRepository, IMapper mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }

        public async Task<FlightByIdResponse> ExecuteAsync(FlightByIdQuery request)
        {
            var flight = await _flightRepository.GetById(request.FlightId);

            if (flight == null)
            {
                throw new Exception("Flight not found");
            }

            var mappedFlight = _mapper.Map<FlightByIdResponse>(flight);

            return mappedFlight;
        }
    }
}
