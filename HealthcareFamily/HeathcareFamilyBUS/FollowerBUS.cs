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
        FollowerDAL followerDAL;
        public FollowerBUS()
        {
            followerDAL = new FollowerDAL();
        }
        public List<FollowerDTO> GetListFollower(string username)
        {
            List<FollowerDTO> list = followerDAL.GetListFollower(username);
            if (list == null)
                return new List<FollowerDTO>();
            return list;
        }
        public List<FollowerDTO> GetAllFollower(string username)
        {
            List<FollowerDTO> list = followerDAL.GetAllFollower(username);
            if (list == null)
                return new List<FollowerDTO>();

            return list;
        }
        public List<FollowerDTO> GetAllFollowerIsFriend(string username)
        {
            List<FollowerDTO> list = followerDAL.GetAllFollowerIsFriend(username);
            if (list == null)
                return new List<FollowerDTO>();

            return list;
        }
        public FollowerDTO GetFollowerInformation(string username, string follower)
        {
            FollowerDTO followerDTO = followerDAL.GetFollowerInformation(username, follower);

            return followerDTO;
        }

        // username: username add follower
        // email: follower email
        public bool AddFollowerByEmail(String username, String email, String relationship)
        {
            UserDAL userDAL = new UserDAL();
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);

            if (userDTO != null)
            {
                return followerDAL.AddFollower(username, userDTO.Username, relationship);
            }
            return false;
        }

        public List<FollowerDTO> GetAllRequestUser(string username)
        {
            List<FollowerDTO> list =  followerDAL.GetAllRequestUser(username);
            if (list == null)
                return new List<FollowerDTO>();
            return list;
        }

        // username: username add follower
        // email: follower email
        public void AcceptFollowByEmail(String username, String email)
        {
            UserDAL userDAL = new UserDAL();
            UserDTO follower = userDAL.GetUserImformationByEmail(email);
            if (follower != null)
            {
                followerDAL.AcceptFollowByEmail(username, follower.Username);
            }
        }

        // username: username add follower
        // email: follower email
        public bool DeleteFollowerByEmail(String username, String email)
        {
            UserDAL userDAL = new UserDAL();
            UserDTO userDTO = userDAL.GetUserImformationByEmail(email);
            if (userDTO != null)
            {
                return followerDAL.DeleteFollower(username, userDTO.Username);
            }
            return false;
        }
    }
}
