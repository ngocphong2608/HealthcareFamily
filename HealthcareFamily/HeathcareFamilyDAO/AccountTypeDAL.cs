using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyDAL
{
    class AccountTypeDAL
    {
        public AccountTypeDTO GetAccountType(string CategoryCode)
        {
            String query = "SELECT * FROM ACCOUNT_TYPE WHERE CategoryCode='" + CategoryCode + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            AccountTypeDTO acc = new AccountTypeDTO();

            acc.Name = dr["Name"].ToString();
            return acc;
        }
    }
}
