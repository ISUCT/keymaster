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
    public class AssignmentsController : ControllerBase
    {
        private readonly ILogger<AssignmentsController> logger;
        private IAssignmentService _assignmentService;

        public AssignmentsController(ILogger<AssignmentsController> logger, IAssignmentService assignmentService)
        {
            this.logger = logger;
            _assignmentService = assignmentService;
        }

        [HttpGet]
        public ActionResult<List<AssignmentDto>> Get()
        {
            return this.Ok(_assignmentService.GetAssignments());
        }

        [HttpPost]
        public ActionResult<AssignmentDto> Insert([FromBody] AssignmentCreateRequestDto assignment)
        {
            return this.Ok(_assignmentService.InsertAssignment(assignment));
        }
    }
}
