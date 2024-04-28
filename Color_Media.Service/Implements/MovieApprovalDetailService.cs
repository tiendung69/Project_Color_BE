using Color_Media.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Media.Service.Implements
{
    public class MovieApprovalDetailService : BaseService<MovieapprovalDetail>, IMovieApprovalDetailService
    {
        public MovieApprovalDetailService(thnd_qlsx_phimContext context) : base(context)
        {
        }
    }
}
