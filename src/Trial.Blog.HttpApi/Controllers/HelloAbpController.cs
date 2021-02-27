using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trial.Blog.Application.HelloAbp;
using Volo.Abp.AspNetCore.Mvc;

namespace Trial.Blog.Controllers
{
    [ApiController]
    [Route("index")]
    public class HelloAbpController : AbpController
    {
        private readonly IHelloAbpService _helloAbpService;

        public HelloAbpController(IHelloAbpService helloAbpService)
        {
            _helloAbpService = helloAbpService;
        }

        [HttpGet]
        public string HelloAbp()
        {
            return _helloAbpService.HelloAbp();
        }
    }
}
