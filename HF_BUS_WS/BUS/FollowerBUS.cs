
using BUS.DAL_WS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HeathcareFamilyBUS
{
    public class FollowerBUS
    {
        HF_DAL_WebserviceSoapClient ws;
        public FollowerBUS()
        {
            ws = new HF_DAL_WebserviceSoapClient();
        }
        public List<FollowerDTO> GetListFollower(string username)
        {
            List<FollowerDTO> list = new List<FollowerDTO>(ws.GetListFollower(username));
            if (list == null)
                return new List<FollowerDTO>();
            return list;
        }
        public List<FollowerDTO> GetAllFollower(string username)
        {
            List<FollowerDTO> list = new List<FollowerDTO>(ws.GetAllFollower(username));
            if (list == null)
                return new List<FollowerDTO>();

            return list;
        }
        public List<FollowerDTO> GetAllFollowerIsFriend(string username)
        {
            List<FollowerDTO> list = new List<FollowerDTO>(ws.GetAllFollowerIsFriend(username));
            if (list == null)
                return new List<FollowerDTO>();

            return list;
        }
        public FollowerDTO GetFollowerInformation(string username, string follower)
        {
            FollowerDTO followerDTO = ws.GetFollowerInformation(username, follower);

            return followerDTO;
        }

        // username: username add follower
        // email: follower email
        public bool AddFollowerByEmail(String username, String email, String relationship)
        {
            
            UserDTO userDTO = ws.GetUserInformationByEmail(email);

            if (userDTO != null)
            {
                return ws.AddFollower(username, userDTO.Username, relationship);
            }
            return false;
        }

        public List<FollowerDTO> GetAllRequestUser(string username)
        {
            List<FollowerDTO> list = new List<FollowerDTO>( ws.GetAllRequestUser(username));
            if (list == null)
                return new List<FollowerDTO>();
            return list;
        }

        // username: username add follower
        // email: follower email
        public void AcceptFollowByEmail(String username, String email)
        {
            
            UserDTO follower = ws.GetUserInformationByEmail(email);
            if (follower != null)
            {
                ws.AcceptFollowByEmail(username, follower.Username);
            }
        }

        // username: username add follower
        // email: follower email
        public bool DeleteFollowerByEmail(String username, String email)
        {
            
            UserDTO userDTO = ws.GetUserInformationByEmail(email);
            if (userDTO != null)
            {
                return ws.DeleteFollower(username, userDTO.Username);
            }
            return false;
        }
    }
}
