using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CoyoteNETCore.DAL;
using CoyoteNETCore.DAL.Entities;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoyoteNetCore.Api
{
    [Route("thread")]
    public class ThreadController : Controller
    {
        private Context _ctx;

        public ThreadController(Context ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public IActionResult GetThreads()
        {
            return new JsonResult(new
            {
                id = 1,
                pubId = "asdausd9p8asd",
                brief = "xxx asd jasd9 8as7d 908as7d aosild jaso9d 8aspod uasd"
            });
        }

        [HttpGet("user")]
        public async Task<IActionResult> AddUser()
        {
         
                await _ctx.Userss.AddAsync(new User());
                await _ctx.SaveChangesAsync();
                var a = await _ctx.Userss.ToListAsync();
         
            return new JsonResult("");
        }
    }
}