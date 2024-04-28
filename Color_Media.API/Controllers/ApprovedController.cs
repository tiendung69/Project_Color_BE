using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class ApprovedController : BaseController<Approved>
    {
        public ApprovedController(IService<Approved> service) : base(service)
        {
        }
    }
}
