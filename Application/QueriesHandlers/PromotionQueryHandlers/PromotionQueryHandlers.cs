using Application.DtoModels;
using Application.Queries.PromotionsQueries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueriesHandlers.PromotionQueryHandlers
{
    class PromotionQueryHandlers : IRequestHandler<GetAllPromotionsQuery, IEnumerable<PromotionDto>>
    {
        private readonly IPromotionsRepo _promotionsRepository;

        public PromotionQueryHandlers(IPromotionsRepo promotionsRepository)
        {
            _promotionsRepository = promotionsRepository;
        }
        public async Task<IEnumerable<PromotionDto>> Handle(GetAllPromotionsQuery request, CancellationToken cancellationToken)
        {
            var result = await _promotionsRepository.GetAllPromotions();
            return result.Select(p => new PromotionDto
            {
                Id = p.Id,
                Discount = p.Discount,
                PromotionalText = p.PromotionalText,

            }).ToList();
        }
    }
}
