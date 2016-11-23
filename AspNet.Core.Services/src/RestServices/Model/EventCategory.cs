using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class EventCategoryViewModel
    {
        public EventCategoryViewModel()
        {
        }

        public string CategoryCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
