using AutoMapper;
using GlobalTicket.TicketManagement.Application.Features.Categories.Commands.CreateCategory;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryList;
using GlobalTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoryListWithEvents;
using GlobalTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using GlobalTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GlobalTicket.TicketManagement.Application.Features.Events.Queries.GetEventList;
using GlobalTicket.TicketManagement.Application.Features.Orders.GetOrderForMonth;
using GlobalTicket.TicketManagement.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTicket.TicketManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category,CategoryEventListVm>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();

            CreateMap<Order, OrdersForMonthDto>();
        }
    }
}
