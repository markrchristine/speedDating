using System.Threading.Tasks;
using NUnit.Framework;
using SpeedDating.Common.DataAccess;
using SpeedDating.Common.Models;

namespace SpeedDating.Test.Common.DataAccess
{
    public class InvestorDataAccessTester
    {
        private InvestorDataAccess _investorDataAccess;
        [SetUp]
        public void Setup()
        {
            _investorDataAccess = new InvestorDataAccess(Constants.DatabaseConnectionString);
        }

        [Test]
        public async Task TestSave()
        {
            var thisInvestor = new Investor("Mark","Christine", "CorpAxe");
            var  investorId = await _investorDataAccess.SaveAsync(thisInvestor);
            var thatInvestor = await _investorDataAccess.GetAsync(investorId);
            Assert.AreEqual(thatInvestor.FirstName,thisInvestor.FirstName);
            Assert.AreEqual(thatInvestor.LastName, thisInvestor.LastName);
            Assert.AreEqual(thatInvestor.Company, thisInvestor.Company);
        }
    }
}
