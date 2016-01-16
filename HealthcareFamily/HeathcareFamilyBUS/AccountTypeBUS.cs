using HealthcareFamilyDAL;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class AccountTypeBUS
    {
        AccountTypeDAL acc;
        public AccountTypeBUS()
        {
            acc = new AccountTypeDAL();
        }
        public List<AccountTypeDTO> GetListAccountType()
        {
            List<AccountTypeDTO> accList =  acc.GetListAccountType();
            if (accList == null)
                return new List<AccountTypeDTO>();
            return accList;
        }
    }
}
