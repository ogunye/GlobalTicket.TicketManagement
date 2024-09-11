﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Features.Orders.GetOrderForMonth
{
    public class PagedOrdersForMonthVm
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }

        public ICollection<OrdersForMonthDto>? OrderForMonth { get; set; }
    }
}
