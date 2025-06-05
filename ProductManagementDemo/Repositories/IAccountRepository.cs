using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IAccountRepository
    {
        AccountMember GetAccountById(string accountID); // Phương thức để lấy một tài khoản theo ID
    }
}
