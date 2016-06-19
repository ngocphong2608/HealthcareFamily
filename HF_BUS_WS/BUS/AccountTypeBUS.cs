using BUS.DAL_WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HeathcareFamilyBUS
{
    public class AccountTypeBUS
    {
        HF_DAL_WebserviceSoapClient acc;
        public AccountTypeBUS()
        {
            acc = new HF_DAL_WebserviceSoapClient();
        }
        public List<AccountTypeDTO> GetListAccountType()
        {
            List<AccountTypeDTO> accList = new List<AccountTypeDTO>(acc.GetListAccountType());
            if (accList == null)
                return new List<AccountTypeDTO>();
            return accList;
        }
    }
}
