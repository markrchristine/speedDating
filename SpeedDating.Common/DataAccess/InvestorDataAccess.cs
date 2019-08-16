using System.Threading.Tasks;
using SpeedDating.Common.Models;

namespace SpeedDating.Common.DataAccess
{
    public class InvestorDataAccess : DataAccessBase
    {
        public InvestorDataAccess(string connectionString) : base(connectionString)
        {
        }

        public async Task<int> SaveAsync(Investor investor)
        {
            return await ExecuteScalarAsync<int>("INSERT Investor(FirstName, LastName, Company) VALUES(@FirstName, @LastName, @Company); select SCOPE_IDENTITY();", investor);
        }

        public async Task<Investor> GetAsync(int investorId)
        {
            return await QueryFirstOrDefaultAsync<Investor>("SELECT * FROM Investor WHERE Id = @investorId", new {investorId});
        }
    }
}
