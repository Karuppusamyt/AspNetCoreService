using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Respository;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Services.Controllers
{
    [Route("api/[controller]")]
    public class EventCategoryController : Controller
    {
        private IEventCategoryRepository EventCategoryRepository;
        public EventCategoryController(IEventCategoryRepository eventCategoryRepository)
        {
            EventCategoryRepository = eventCategoryRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<EventCategoryViewModel> Get()
        {
            return EventCategoryRepository.GetList().Select(item => item.ToViewModel()).ToList();
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
