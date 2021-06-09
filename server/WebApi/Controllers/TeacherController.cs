using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;
using WebApi.Models.DBManager;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly ILogger<TeacherController> logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                return db.Teachers.ToArray();
            }
        }
    }
}
