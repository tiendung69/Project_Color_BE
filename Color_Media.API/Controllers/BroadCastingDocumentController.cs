using Color_Media.Models;
using Color_Media.Service;
using Microsoft.AspNetCore.Mvc;

namespace Color_Media.API.Controllers
{
    public class BroadCastingDocumentController : BaseController<Broadcastingdocument>
    {
        public BroadCastingDocumentController(IService<Broadcastingdocument> service) : base(service)
        {
        }
    }
}
