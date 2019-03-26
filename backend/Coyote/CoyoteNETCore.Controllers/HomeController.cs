using CoyoteNETCore.DAL;
using CoyoteNETCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CoyoteNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : DefaultController
    {
        private readonly TestService _service;
        private readonly Context _db;

        public HomeController(Context db, TestService service)
        {
            _db = db;
            _service = service;
        }

        [HttpPost("confirm")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public IActionResult SampleEndpoint()
        {
            _service.Test();
            return Ok();
        }
    }
}