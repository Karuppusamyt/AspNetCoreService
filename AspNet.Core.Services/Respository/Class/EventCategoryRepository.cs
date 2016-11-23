using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;

namespace Respository
{
    public class EventCategoryRepository : IEventCategoryRepository
    {
        private readonly DbContext _dbContext;
        private Boolean disposed;
        //private List<EventCategory> Events;
        public EventCategoryRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public EventCategory Add(EventCategory entity)
        {
            throw new NotImplementedException();
        }

        public EventCategory Delete(string id)
        {
            throw new NotImplementedException();
        }

        public EventCategory Get(string id)
        {
            var query = _dbContext.Set<EventCategory>().FirstOrDefault(item => item.CategoryCode == id);
            return query;
        }

        public IEnumerable<EventCategory> GetList()
        {
            //var query = DbContext
            //    .Set<Product>()
            //    .AsQueryable()
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);

            //var query = _dbContext.Set<EventCategory>()
            //                .AsQueryable();

            //return query;

            var query = new List<EventCategory> {
                new EventCategory { CategoryCode = "Test01", Name = "Name01", Description = "Desc01" }
            }.AsQueryable();
            return query;

        }

        public EventCategory Update(string id, EventCategory entity)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~EventCategoryRepository() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            if (!disposed)
            {
                if (_dbContext != null)
                {
                    _dbContext.Dispose();
                    disposed = true;
                }
            }
        }

        #endregion
    }
}
