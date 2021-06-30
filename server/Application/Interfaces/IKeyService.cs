namespace Application.Interfaces
{
    using System.Collections.Generic;
    using Application.DTO.Request;
    using Application.ViewModels;

    public interface IKeyService
    {
        List<KeyDto> GetKeys();

        KeyDto InsertKey(KeyCreateRequestDto key);
    }
}
