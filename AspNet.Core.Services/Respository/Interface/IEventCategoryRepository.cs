using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Respository
{
    public interface IEventCategoryRepository : IDisposable
    {
        IEnumerable<EventCategory> GetList();
        EventCategory Get(string id);
        EventCategory Add(EventCategory entity);
        EventCategory Update(string id , EventCategory entity);
        EventCategory Delete(string id);

    }
}
