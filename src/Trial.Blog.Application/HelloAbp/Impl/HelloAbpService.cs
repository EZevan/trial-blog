using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial.Blog.Application.HelloAbp.Impl
{
    public class HelloAbpService : TrialBlogApplicationServiceBase, IHelloAbpService
    {
        public string HelloAbp()
        {
            return "Hello Abp!";
        }
    }
}
