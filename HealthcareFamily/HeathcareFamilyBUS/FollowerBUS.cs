using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeathcareFamilyBUS
{
    public class FollowerBUS
    {
        FollowerDAL follower;
        public FollowerBUS()
        {
            follower = new FollowerDAL();
        }
        public List<FollowerDTO> GetListFollower(string username)
        {
            return follower.GetListFollower(username);
        }
    }
}
