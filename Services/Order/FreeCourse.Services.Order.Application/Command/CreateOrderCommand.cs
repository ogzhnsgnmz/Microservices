﻿using FreeCourse.Services.Order.Application.Dtos;
using FreeCourse.Shared.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeCourse.Services.Order.Application.Command
{
   public class CreateOrderCommand:IRequest<Response<CreateOrderCommand>>
    {
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }

        public AddressDto Address { get; set; }
    }
}
