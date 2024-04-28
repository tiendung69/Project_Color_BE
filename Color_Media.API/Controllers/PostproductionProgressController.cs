using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class PostproductionProgressController : BaseController<PostproductionProgress>
    {
        public PostproductionProgressController(IService<PostproductionProgress> service) : base(service)
        {
        }
    }
}
