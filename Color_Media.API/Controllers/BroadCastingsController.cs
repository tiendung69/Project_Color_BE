using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class BroadCastingsController : BaseController<Broadcasting>
    {
        public BroadCastingsController(IBroadcastingService service) : base(service)
        {
        }
    }
}
