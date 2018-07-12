﻿using Abstractions.CQRS;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Contract.Command.Departure
{
    class DeleteDepartureCommand: ICommand
    {
        public Guid DepartureId { get; set; }
    }
}
