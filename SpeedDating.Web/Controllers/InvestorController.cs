using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SpeedDating.Common.DataAccess;
using SpeedDating.Common.Models;
using SpeedDating.Common.Settings;

namespace SpeedDating.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private readonly IOptions<ConnectionStrings> _options;

        public InvestorController(IOptions<ConnectionStrings> options)
        {
            _options = options;
        }


        [HttpGet("{id}", Name = "Get")]
        public async Task<Investor> Get(int id)
        {
            using (var investorDataAccess = new InvestorDataAccess(_options.Value.Database))
            {
                return await investorDataAccess.GetAsync(id);
            }
        }
    }
}
