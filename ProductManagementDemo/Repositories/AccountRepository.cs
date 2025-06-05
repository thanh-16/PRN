using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository // Triển khai interface IAccountRepository
    {
        // Phương thức này triển khai GetAccountById() từ interface IAccountRepository
        public AccountMember GetAccountById(string accountID) => AccountDAO.GetAccountById(accountID);
    }
}
