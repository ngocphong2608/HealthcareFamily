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
            List<FollowerDTO> list = follower.GetListFollower(username);
            if (list == null)
                return new List<FollowerDTO>();
            return list;
        }

        // username: username add follower
        // email: follower email
        public bool AddFollowerByEmail(String username, String email, String relationship)
        {
            UserDAL userDAL = new UserDAL();
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);

            if (userDTO != null)
            {
                return follower.AddFollower(username, userDTO.Username, relationship);
            }
            return false;
        }
    }
}
