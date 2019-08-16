using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SpeedDating.Common.DataAccess;
using SpeedDating.Common.Models;
using SpeedDating.Common.Settings;

namespace SpeedDating.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IOptions<ConnectionStrings> _options;
        public RegistrationController(IOptions<ConnectionStrings> options)
        {
            _options = options;
        }

        [HttpPost]
        public async Task<int> Post([FromBody] Investor investor)
        {
            //save the investor
            using (var investorDataAccess = new InvestorDataAccess(_options.Value.Database))
            {
                return await investorDataAccess.SaveAsync(investor);
            }
            //TODO : save the investor to the event
        }
    }
}
