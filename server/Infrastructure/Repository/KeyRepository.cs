namespace CleanArchitecture.Infra.Data.Repositories
{
    using System.Linq;
    using Domain.Models;
    using Domain.Repository;
    using Infrastructure.EF;
    using Microsoft.EntityFrameworkCore;

    public class KeyRepository : IKeyRepository
    {
        private DatabaseContext context;

        public KeyRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Key InsertKey(Key key)
        {
            var entity = context.Add(key);
            context.SaveChanges();
            return entity.Entity;
        }

        IQueryable<Key> IKeyRepository.GetKeys()
        {
            return context.Keys.Include(u => u.Teacher).AsNoTracking();
        }
    }
}
