using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class AccountTypeDAL
    {
        public String GetAccountTypeName(String CategoryCode)
        {
            String query = "SELECT Name FROM ACCOUNT_TYPE WHERE CategoryCode='" + CategoryCode + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            AccountTypeDTO acc = new AccountTypeDTO();

            return dr["Name"].ToString();
        }
        public String GetAccountTypeCode(String accountType)
        {
            String query = "SELECT CategoryCode FROM ACCOUNT_TYPE WHERE name='" + accountType + "'";

            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];
            AccountTypeDTO acc = new AccountTypeDTO();

            return dr["CategoryCode"].ToString();
        }
        public List<AccountTypeDTO> GetListAccountType()
        {
            String query = "SELECT CategoryCode, Name FROM ACCOUNT_TYPE";

            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<AccountTypeDTO> accs = new List<AccountTypeDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                AccountTypeDTO acc = new AccountTypeDTO();
                acc.Name = dr["Name"].ToString();
                acc.Code = dr["CategoryCode"].ToString();
                accs.Add(acc);
            }

            return accs;
        }
    }
}
