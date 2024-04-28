using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class MovieApprovalDetailController : BaseController<MovieapprovalDetail>
    {
        public MovieApprovalDetailController(IService<MovieapprovalDetail> service) : base(service)
        {
        }
    }
}
