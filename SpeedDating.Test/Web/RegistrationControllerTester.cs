using System.Threading.Tasks;
using NUnit.Framework;
using SpeedDating.Common.Settings;
using SpeedDating.Web.Controllers;
using Microsoft.Extensions.Options;
using SpeedDating.Common.DataAccess;
using SpeedDating.Common.Models;

namespace SpeedDating.Test.Web
{
    public class RegistrationControllerTester
    {
        private RegistrationController _controller;

        [SetUp]
        public void Setup()
        {
            _controller = new RegistrationController(new OptionsWrapper<ConnectionStrings>(new ConnectionStrings { Database = Constants.DatabaseConnectionString }));
        }
        [Test]
        public async Task Register()
        {
            await _controller.Post(new Investor("Web","Based","User"));
            //TODO : Assert that the Investor is Registered
            Assert.True(true);
        }
    }
}
