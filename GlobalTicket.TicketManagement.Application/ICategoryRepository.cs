﻿using GlobalTicket.TicketManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
    }
}
