namespace Domain.Repository
{
    using System.Linq;
    using Domain.Models;

    public interface IKeyRepository
    {
        IQueryable<Key> GetKeys();

        public Key GetKeyById(int id);

        Key InsertKey(Key key);
    }
}
