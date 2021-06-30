namespace WebApi.Controllers
{
    using System.Collections.Generic;
    using Application.DTO.Request;
    using Application.Interfaces;
    using Application.ViewModels;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    [ApiController]
    [Route("api/[controller]")]
    public class KeysController : ControllerBase
    {
        private readonly ILogger<KeysController> _logger;
        private IKeyService _keyService;

        public KeysController(ILogger<KeysController> logger, IKeyService keyService)
        {
            _logger = logger;
            _keyService = keyService;
        }

        [HttpGet]
        public ActionResult<List<KeyDto>> Get()
        {
            return this.Ok(_keyService.GetKeys());
        }

        [HttpPost]
        public ActionResult<KeyDto> Insert([FromBody] KeyCreateRequestDto key)
        {
            return this.Ok(_keyService.InsertKey(key));
        }
    }
}
