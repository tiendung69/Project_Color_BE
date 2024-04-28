using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class MovieApprovalsController : BaseController<Movieapproval>
    {
        public MovieApprovalsController(IService<Movieapproval> service) : base(service)
        {
        }
    }
}
