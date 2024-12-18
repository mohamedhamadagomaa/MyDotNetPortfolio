using Core.Entities;
using Core.Interface;
using Services.Repository;

namespace Services.UnitOfWOrk
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly AppDbContext _context;
        private IGenericRepository<T> _entity;

        public UnitOfWork(AppDbContext context)
        {
            this._context = context;
        }

        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
