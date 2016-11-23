using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;


namespace Services
{
    public static class EventCategoryMapper
    {
        public static EventCategoryViewModel ToViewModel(this EventCategory entity)
        {
            return entity == null ? null : new EventCategoryViewModel
            {
                CategoryCode = entity.CategoryCode,
                Description = entity.Description,
                Name = entity.Name
            };
        }

        public static EventCategory ToEntity(this EventCategoryViewModel viewModel)
        {
            return viewModel == null ? null : new EventCategory
            {
                CategoryCode = viewModel.CategoryCode,
                Description = viewModel.Description,
                Name = viewModel.Name
            };
        }

    }
}
