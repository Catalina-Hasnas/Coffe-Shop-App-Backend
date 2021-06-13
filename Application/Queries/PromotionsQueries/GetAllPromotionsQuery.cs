using Application.DtoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.PromotionsQueries
{
    public class GetAllPromotionsQuery : IRequest<IEnumerable<PromotionDto>>
    {
    }
}
