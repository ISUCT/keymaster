namespace Application.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using Application.DTO.Request;
    using Application.Interfaces;
    using Application.ViewModels;
    using Domain.Repository;

    public class KeyService : IKeyService
    {
        private IKeyRepository _keyRepository;

        public KeyService(IKeyRepository keyRepository)
        {
            _keyRepository = keyRepository;
        }

        public List<KeyDto> GetKeys()
        {
            return _keyRepository.GetKeys().Select(x => new KeyDto(x)).ToList();
        }

        public KeyDto InsertKey(KeyCreateRequestDto key)
        {
            var createdKey = new KeyDto(_keyRepository.InsertKey(key.ToModel()));
            return createdKey;
        }
    }
}
