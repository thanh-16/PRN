using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            AccountMember account = null;
            try
            {
                using var context = new MyStoreContext();
                // SỬA ĐIỀU KIỆN SO SÁNH CHO PHÙ HỢP VỚI CHUỖI
                account = context.AccountMembers.FirstOrDefault(acc => acc.MemberId.Equals(accountID));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return account;
        }
    }
}
