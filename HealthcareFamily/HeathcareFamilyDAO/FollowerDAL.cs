using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcareFamilyDAL
{
    public class FollowerDAL
    {
        public bool AddFollower(String username, String follower, String relationship)
        {
            String query = "INSERT INTO FOLLOWER_INFORMATION VALUES(";
            query += "'" + username + "',";
            query += "'" + follower + "',";
            query += "'" + relationship + "',";
            query += Convert.ToString(0) + ")";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<FollowerDTO> GetListFollower(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE USERNAME='" + username + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follower = new FollowerDTO();
                follower.FollowerUsername = dr["Follower_Username"].ToString();
                follower.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
                follower.Relationship = dr["Relationship"].ToString();
                follower.Username = dr["Username"].ToString();
                ListFollower.Add(follower);
            }

            return ListFollower;
        }
        public List<FollowerDTO> GetAllFollower(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE (USERNAME='" + username + "' ";
            query += "OR Follower_Username='" + username + "') ";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follower = new FollowerDTO();
                follower.FollowerUsername = dr["Follower_Username"].ToString();
                follower.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
                follower.Relationship = dr["Relationship"].ToString();
                follower.Username = dr["Username"].ToString();

                if (follower.FollowerUsername == username)
                {
                    follower.FollowerUsername = follower.Username;
                    follower.Username = username;
                }

                ListFollower.Add(follower);
            }

            return ListFollower;
        }
        public List<FollowerDTO> GetAllFollowerIsFriend(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE (USERNAME='" + username + "' ";
            query += "OR Follower_Username='" + username + "') ";
            query += "AND IsUserAccepted='True'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follower = new FollowerDTO();
                follower.FollowerUsername = dr["Follower_Username"].ToString();
                follower.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
                follower.Relationship = dr["Relationship"].ToString();
                follower.Username = dr["Username"].ToString();

                if (follower.FollowerUsername == username)
                {
                    follower.FollowerUsername = follower.Username;
                    follower.Username = username;
                }

                ListFollower.Add(follower);
            }

            return ListFollower;
        }

        public FollowerDTO GetFollowerInformation(string username, string follower)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE USERNAME='" + username + "' ";
            query += "AND Follower_Username='" + follower + "'";

            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            DataRow dr = dt.Rows[0];

            FollowerDTO followerDTO = new FollowerDTO();
            followerDTO.FollowerUsername = dr["Follower_Username"].ToString();
            //followerDTO.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
            followerDTO.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
            followerDTO.Relationship = dr["Relationship"].ToString();
            followerDTO.Username = dr["Username"].ToString();

            return followerDTO;
        }

        public List<FollowerDTO> GetAllRequestUser(string username)
        {
            String query = "SELECT * FROM FOLLOWER_INFORMATION WHERE Follower_Username='" + username + "' AND IsUserAccepted='False'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count == 0)
                return null;

            List<FollowerDTO> ListFollower = new List<FollowerDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                FollowerDTO follower = new FollowerDTO();
                follower.FollowerUsername = dr["Follower_Username"].ToString();
                //follower.IsPermitAccessInfo = Boolean.Parse(dr["IsPermitAccessInfo"].ToString());
                follower.IsUserAccepted = Boolean.Parse(dr["IsUserAccepted"].ToString());
                follower.Relationship = dr["Relationship"].ToString();
                follower.Username = dr["Username"].ToString();
                ListFollower.Add(follower);
            }

            return ListFollower;
        }


        public void AcceptFollowByEmail(String username, String follower)
        {
            String query = "UPDATE FOLLOWER_INFORMATION ";
            query += "SET IsUserAccepted='True' ";
            query += "WHERE Username=";
            query += "'" + follower + "'";
            query += "AND ";
            query += "Follower_Username='" + username + "'";

            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteFollower(String username, String follower)
        {
            String query = "DELETE FOLLOWER_INFORMATION WHERE ";
            query += "(Username='" + username + "'";
            query += " AND ";
            query += "Follower_Username='" + follower + "') ";
            query += "OR (Username='" + follower + "'";
            query += " AND ";
            query += "Follower_Username='" + username + "') ";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
