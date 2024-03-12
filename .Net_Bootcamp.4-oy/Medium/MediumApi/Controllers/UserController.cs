using MediatR;
using Medium.Application.Commads;
using Microsoft.AspNetCore.Mvc;

namespace MediumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            await _mediator.Send(command);

            return Ok("Malumot yaratildi");
        }
    }
}
