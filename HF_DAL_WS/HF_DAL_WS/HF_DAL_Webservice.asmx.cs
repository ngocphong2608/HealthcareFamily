using HealthcareFamilyDAL;
using HealthcareFamilyDTO;
using HeathcareFamilyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HF_DAL_WS
{
    /// <summary>
    /// Summary description for HF_DAL_Webservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HF_DAL_Webservice : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public String GetAccountTypeName(String CategoryCode)
        {
            AccountTypeDAL acc = new AccountTypeDAL();

            return acc.GetAccountTypeName(CategoryCode);
        }

        [WebMethod]
        public String GetAccountTypeCode(String accountType)
        {
            AccountTypeDAL acc = new AccountTypeDAL();

            return acc.GetAccountTypeCode(accountType);
        }

        [WebMethod]
        public List<AccountTypeDTO> GetListAccountType()
        {
            AccountTypeDAL acc = new AccountTypeDAL();

            return acc.GetListAccountType();
        }

        // new
        [WebMethod]
        public List<AppointmentScheduleDTO> GetListAppointmentScheduleByUsername(string username)
        {
            AppointmentScheduleDAL app = new AppointmentScheduleDAL();
            return app.GetListAppointmentSchedule(username);
        }

        [WebMethod]
        public void CreateAppointmentSchedule(AppointmentScheduleDTO app)
        {
            AppointmentScheduleDAL appDAL = new AppointmentScheduleDAL();
            appDAL.CreateAppointmentSchedule(app);
        }

        [WebMethod]
        public List<AppointmentScheduleDTO> GetListAppointmentSchedule(string username, string follower)
        {
            AppointmentScheduleDAL appDAL = new AppointmentScheduleDAL();
            return appDAL.GetListAppointmentSchedule(username, follower);
        }

        [WebMethod]
        public void DeleteAppointmentSchedule(AppointmentScheduleDTO appDTO)
        {
            AppointmentScheduleDAL appDAL = new AppointmentScheduleDAL();
            appDAL.DeleteAppointmentSchedule(appDTO);
        }

        [WebMethod]
        public bool AddFollower(String username, String follower, String relationship)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.AddFollower(username, follower, relationship);
        }

        [WebMethod]
        public List<FollowerDTO> GetListFollower(string username)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.GetListFollower(username);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllFollower(string username)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.GetListFollower(username);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllFollowerIsFriend(string username)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.GetAllFollowerIsFriend(username);
        }

        [WebMethod]
        public FollowerDTO GetFollowerInformation(string username, string follower)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.GetFollowerInformation(username, follower);
        }

        [WebMethod]
        public List<FollowerDTO> GetAllRequestUser(string username)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.GetAllRequestUser(username);
        }

        [WebMethod]
        public void AcceptFollowByEmail(String username, String follower)
        {
            FollowerDAL dal = new FollowerDAL();
            dal.AcceptFollowByEmail(username, follower);
        }

        [WebMethod]
        public bool DeleteFollower(String username, String follower)
        {
            FollowerDAL dal = new FollowerDAL();
            return dal.DeleteFollower(username, follower);
        }

        [WebMethod]
        public List<HealthcareDTO> GetListHealthcareInformation(string username)
        {
            HealthcareDAL dal = new HealthcareDAL();
            return dal.GetListHealthcareInformation(username);
        }

        [WebMethod]
        public void InsertHealthCareInformation(String username, HealthcareDTO healthcare)
        {
            HealthcareDAL dal = new HealthcareDAL();
            dal.InsertHealthCareInformation(username, healthcare);
        }

        [WebMethod]
        public List<MessageDTO> GetListMessage(string username, string follower)
        {
            MessageDAL dal = new MessageDAL();
            return dal.GetListMessage(username, follower);
        }

        [WebMethod]
        public List<NotificationDTO> GetListNotification(string username)
        {
            NotificationDAL dal = new NotificationDAL();
            return dal.GetListNotification(username);
        }

        [WebMethod]
        public void SetNotification(string username, string follower, string time, string detail)
        {
            NotificationDAL dal = new NotificationDAL();
            dal.SetNotification(username, follower, time, detail);
        }

        [WebMethod]
        public void UpdateSharingInfo(String username, String follower, bool share)
        {
            SharingInfoDAL dal = new SharingInfoDAL();
            dal.UpdateSharingInfo(username, follower, share);
        }

        [WebMethod]
        public void SetSharingInfo(String username, String follower, bool share)
        {
            SharingInfoDAL dal = new SharingInfoDAL();
            dal.SetSharingInfo(username, follower, share);
        }

        [WebMethod]
        public SharingInfoDTO GetSharingInfo(String username, String follower)
        {
            SharingInfoDAL dal = new SharingInfoDAL();
            return dal.GetSharingInfo(username, follower);
        }

        [WebMethod]
        public UserDTO GetUserInformation(String username)
        {
            UserDAL dal = new UserDAL();
            return dal.GetUserInformation(username);
        }

        [WebMethod]
        public void SetStatus(String username, bool IsOnline)
        {
            UserDAL dal = new UserDAL();
            dal.SetStatus(username, IsOnline);
        }

        [WebMethod]
        public bool SignIn(String username, String password)
        {
            UserDAL dal = new UserDAL();
            return dal.SignIn(username, password);
        }

        [WebMethod]
        public bool IsUserExisted(string username)
        {
            UserDAL dal = new UserDAL();
            return dal.IsUserExisted(username);
        }

        [WebMethod]
        public bool IsEmailExisted(string email)
        {
            UserDAL dal = new UserDAL();
            return dal.IsEmailExisted(email);
        }

        [WebMethod]
        public bool SignUp(String username, String password, String name, DateTime birthday, string gender, String email, String accountType)
        {
            UserDAL dal = new UserDAL();
            return dal.SignUp(username, password, name, birthday, gender, email, accountType);
        }

        [WebMethod]
        public bool AllowAccess(String username, String follower)
        {
            UserDAL dal = new UserDAL();
            return dal.AllowAccess(username, follower);
        }

        [WebMethod]
        public bool UnAllowAccess(String username, String follower)
        {
            UserDAL dal = new UserDAL();
            return dal.UnAllowAccess(username, follower);
        }

        [WebMethod]
        public UserDTO GetUserInformationByEmail(string email)
        {
            UserDAL dal = new UserDAL();
            return dal.GetUserInformationByEmail(email);
        }

        [WebMethod]
        public List<UserDTO> GetListUser(string info)
        {
            UserDAL dal = new UserDAL();
            return dal.GetListUser(info);
        }

        [WebMethod]
        public void UpdateAvatar(string username, byte[] img)
        {
            UserDAL dal = new UserDAL();
            dal.UpdateAvatar(username, img);
        }
    }
}
