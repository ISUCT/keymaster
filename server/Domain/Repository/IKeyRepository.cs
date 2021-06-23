namespace Domain.Repository
{
    using System.Linq;
    using Domain.Models;

    public interface IKeyRepository
    {
        IQueryable<Key> GetKeys();

        Key InsertKey(Key key);
    }
}
