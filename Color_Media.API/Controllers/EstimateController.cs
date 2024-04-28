using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class EstimateController : BaseService<Estimate>
    {
        public EstimateController(thnd_qlsx_phimContext context) : base(context)
        {
        }
    }
}
