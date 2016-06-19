using BUS.DAL_WS;
using HeathcareFamilyBUS;
using HealthcareFamilyBUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HF_BUS_WS
{
    /// <summary>
    /// Summary description for HF_BUS_Webservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HF_BUS_Webservice : System.Web.Services.WebService
    {
        AccountTypeBUS accBUS = new AccountTypeBUS();
        AppointmentScheduleBUS appBUS = new AppointmentScheduleBUS();
        FollowerBUS followerBUS = new FollowerBUS();
        HealthcareBUS healthBUS = new HealthcareBUS();
        NotificationBUS notiBUS = new NotificationBUS();
        SharingInfoBUS shareBUS = new SharingInfoBUS();
        UserBUS userBUS = new UserBUS();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<AccountTypeDTO> GetListAccountType()
        {
            return accBUS.GetListAccountType();
        }

        [WebMethod]
        public List<AppointmentScheduleDTO> GetListAppointmentScheduleByUsername(String username)
        {
            return appBUS.GetListAppointmentSchedule(username);
        }

        [WebMethod]
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username, string follower)
        {
            return appBUS.GetListAppointmentSchedule(username, follower);
        }

        [WebMethod]
        public void CreateAppointmentSchedule(string username, string doctorEmail, string time, string detail)
        {
            appBUS.CreateAppointmentSchedule(username, doctorEmail, time, detail);
        }

        [WebMethod]
        public void DeleteAppointmentSchedule(AppointmentScheduleDTO appDTO)
        {
            appBUS.DeleteAppointmentSchedule(appDTO);
        }

        [WebMethod]
        public List<FollowerDTO> GetListFollower(string username)
        {
            return followerBUS.GetListFollower(username);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllFollower(string username)
        {
            return followerBUS.GetAllFollower(username);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllFollowerIsFriend(string username)
        {
            return followerBUS.GetAllFollowerIsFriend(username);
        }

        [WebMethod]
        public FollowerDTO GetFollowerInformation(string username, string follower)
        {
            return followerBUS.GetFollowerInformation(username, follower);
        }

        [WebMethod]
        public bool AddFollowerByEmail(String username, String email, String relationship)
        {
            return followerBUS.AddFollowerByEmail(username, email, relationship);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllRequestUser(string username)
        {
            return followerBUS.GetAllRequestUser(username);
        }

        [WebMethod]
        public void AcceptFollowByEmail(String username, String email)
        {
            followerBUS.AcceptFollowByEmail(username, email);
        }

        [WebMethod]
        public bool DeleteFollowerByEmail(String username, String email)
        {
            return followerBUS.DeleteFollowerByEmail(username, email);
        }

        [WebMethod]
        public List<HealthcareDTO> GetListHealthcareInformation(String username)
        {
            return healthBUS.GetListHealthcareInformation(username);
        }

        [WebMethod]
        public void InsertHealthCareInformation(String username, HealthcareDTO healthcare)
        {
            healthBUS.InsertHealthCareInformation(username, healthcare);
        }

        [WebMethod]
        public List<MessageDTO> GetListMessage(String username, String follower)
        {
            MessageBUS bus = new MessageBUS();
            return bus.GetListMessage(username, follower);
        }

        [WebMethod]
        public List<NotificationDTO> GetListNotification(String username)
        {
            return notiBUS.GetListNotification(username);
        }

        [WebMethod]
        public void SetNotification(string username, string follower, DateTime dt, string detail)
        {
            notiBUS.SetNotification(username, follower, dt, detail);
        }

        [WebMethod]
        public SharingInfoDTO GetSharingInfo(String username, String follower)
        {
            return shareBUS.GetSharingInfo(username, follower);
        }

        [WebMethod]
        public void UpdateSharingInfo(String username, String follower, bool share)
        {
            shareBUS.UpdateSharingInfo(username, follower, share);
        }

        [WebMethod]
        public void SetSharingInfo(String username, String follower, bool share)
        {
            shareBUS.SetSharingInfo(username, follower, share);
        }

        [WebMethod]
        public void SetSharingInfoByEmail(string username, string email, bool share)
        {
            shareBUS.SetSharingInfoByEmail(username, email, share);
        }

        [WebMethod]
        public UserDTO GetUserInformation(String username)
        {
            return userBUS.GetUserInformation(username);
        }

        [WebMethod]
        public UserDTO GetUserInformationByEmail(String email)
        {
            return userBUS.GetUserInformationByEmail(email);
        }

        [WebMethod]
        public bool SignIn(String username, String password)
        {
            return userBUS.SignIn(username, password);
        }

        [WebMethod]
        public void SignOut(String username)
        {
            userBUS.SignOut(username);
        }

        [WebMethod]
        public bool SignUp(String username, String password, String name, DateTime birthday, String gender, String email, String accountType)
        {
            return userBUS.SignUp(username, password, name, birthday, gender, email, accountType);
        }

        [WebMethod]
        public bool AllowAccessInfoByEmail(String username, String email)
        {
            return userBUS.AllowAccessInfoByEmail(username, email);
        }

        [WebMethod]
        public bool UnAllowAccessInfoByEmail(String username, String email)
        {
            return userBUS.UnAllowAccessInfoByEmail(username, email);
        }

        [WebMethod]
        public bool IsEmailExisted(String email)
        {
            return userBUS.IsEmailExisted(email);
        }

        [WebMethod]
        public List<UserDTO> GetListUserNotFriend(string username, string info)
        {
            return userBUS.GetListUserNotFriend(username, info);
        }

        [WebMethod]
        public void UpdateAvatar(string username, byte[] img)
        {
            userBUS.UpdateAvatar(username, img);
        }
    }
}
