using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class PreproductionProgressController : BaseController<PreproductionProgress>
    {
        public PreproductionProgressController(IService<PreproductionProgress> service) : base(service)
        {
        }
    }
}
