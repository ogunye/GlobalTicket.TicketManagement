﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Events.Commands.Delete_Event
{
    public class DeleteEventCommand :IRequest
    {
        public Guid EventId { get; set; }
    }
}
