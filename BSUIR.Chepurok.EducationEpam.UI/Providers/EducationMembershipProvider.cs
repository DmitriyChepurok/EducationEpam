using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BSUIR.Chepurok.EducationEpam.UI.Providers
{
  public class EducationMembershipProvider : MembershipProvider
  {
    private readonly IServiceBll<RoleEntity> _roleService;
    private readonly IServiceBll<UserEntity> _userService;

    public EducationMembershipProvider()
      : this(
      DependencyResolver.Current.GetService<IServiceBll<RoleEntity>>(),
      DependencyResolver.Current.GetService<IServiceBll<UserEntity>>())
    {
    }

    public EducationMembershipProvider(
      IServiceBll<RoleEntity> roleService,
      IServiceBll<UserEntity> userService)
    {
      _roleService = roleService;
      _userService = userService;
    }

    public async Task<MembershipUser> CreateUser(string email, string password, string firstName,
      string surName, string image, string post)
    {
      var membershipUser = await GetUserAsync(email, false);

      if (membershipUser != null)
      {
        return null;
      }

      var user = new UserEntity
      {
        Email = email,
        Password = password,
        Firstname = firstName,
        Surname = surName,
        Image = image,
        PostInCompany = post        
      };

      var role = _roleService
        .SelectAll()
        .FirstOrDefault(r => r.NameRole == "User");

      if (role != null)
      {
        user.RoleID = role.RoleID;
      }

      _userService.Insert(user);
      membershipUser = await GetUserAsync(email, false);

      return membershipUser;
    }
    

    public override string ApplicationName
    {
      get
      {
        throw new NotImplementedException();
      }
      set
      {
        throw new NotImplementedException();
      }
    }

    public override bool ChangePassword(string username, string oldPassword, string newPassword)
    {
      throw new NotImplementedException();
    }

    public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
    {
      throw new NotImplementedException();
    }

    public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out MembershipCreateStatus status)
    {
      throw new NotImplementedException();
    }

    public override bool DeleteUser(string username, bool deleteAllRelatedData)
    {
      throw new NotImplementedException();
    }

    public override bool EnablePasswordReset
    {
      get { throw new NotImplementedException(); }
    }

    public override bool EnablePasswordRetrieval
    {
      get { throw new NotImplementedException(); }
    }

    public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
    {
      throw new NotImplementedException();
    }

    public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
    {
      throw new NotImplementedException();
    }

    public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
    {
      throw new NotImplementedException();
    }

    public override int GetNumberOfUsersOnline()
    {
      throw new NotImplementedException();
    }

    public override string GetPassword(string username, string answer)
    {
      throw new NotImplementedException();
    }

    public override MembershipUser GetUser(string username, bool userIsOnline)
    {
      var userT = _userService.SelectAllAsync();
      userT.Wait();
      var user = userT.Result.FirstOrDefault(e => e.Email == username);


      if (user == null)
      {
        return null;
      }

      var memberUser = new MembershipUser("EducationMembershipProvider", user.Firstname + " " + user.Surname,
        null, user.Password, null, null, false, false, DateTime.Now,
        DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);

      return memberUser;
    }

    public async Task<MembershipUser> GetUserAsync(string username, bool userIsOnline)
    {
      var userList = await _userService.SelectAllAsync();

      var user = userList.FirstOrDefault(e => e.Email == username);


      if (user == null)
      {
        return null;
      }

      var memberUser = new MembershipUser("EducationMembershipProvider", user.Firstname + " " + user.Surname,
        null, user.Password, null, null, false, false, DateTime.Now,
        DateTime.MinValue, DateTime.MinValue, DateTime.MinValue, DateTime.MinValue);

      return memberUser;
    }

    public override MembershipUser GetUser(object providerUserKey, bool userIsOnline)
    {
      throw new NotImplementedException();
    }

    public override string GetUserNameByEmail(string email)
    {
      throw new NotImplementedException();
    }

    public override int MaxInvalidPasswordAttempts
    {
      get { throw new NotImplementedException(); }
    }

    public override int MinRequiredNonAlphanumericCharacters
    {
      get { throw new NotImplementedException(); }
    }

    public override int MinRequiredPasswordLength
    {
      get { throw new NotImplementedException(); }
    }

    public override int PasswordAttemptWindow
    {
      get { throw new NotImplementedException(); }
    }

    public override MembershipPasswordFormat PasswordFormat
    {
      get { throw new NotImplementedException(); }
    }

    public override string PasswordStrengthRegularExpression
    {
      get { throw new NotImplementedException(); }
    }

    public override bool RequiresQuestionAndAnswer
    {
      get { throw new NotImplementedException(); }
    }

    public override bool RequiresUniqueEmail
    {
      get { throw new NotImplementedException(); }
    }

    public override string ResetPassword(string username, string answer)
    {
      throw new NotImplementedException();
    }

    public override bool UnlockUser(string userName)
    {
      throw new NotImplementedException();
    }

    public override void UpdateUser(MembershipUser user)
    {
      throw new NotImplementedException();
    }

    public override bool ValidateUser(string username, string password)
    {
      var user = _userService.SelectAll().FirstOrDefault(e => e.Email == username);
      return user != null && Equals(user.Password, password);
    }
  }
}