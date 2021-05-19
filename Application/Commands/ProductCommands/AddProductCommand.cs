﻿using Application.DtoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.ProductCommands
{
    public class AddProductCommand : IRequest<ProductDto>
    {
        public int Amount { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
    }
}
