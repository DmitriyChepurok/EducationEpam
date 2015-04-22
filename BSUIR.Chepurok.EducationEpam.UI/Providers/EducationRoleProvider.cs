using BSUIR.Chepurok.EducationEpam.BLL.Entities;
using BSUIR.Chepurok.EducationEpam.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BSUIR.Chepurok.EducationEpam.UI.Providers
{
  public class EducationRoleProvider : RoleProvider
  {
    private readonly IServiceBll<RoleEntity> _roleService;
    private readonly IServiceBll<UserEntity> _userService;

    public EducationRoleProvider()
      : this(
      DependencyResolver.Current.GetService<IServiceBll<RoleEntity>>(),
      DependencyResolver.Current.GetService<IServiceBll<UserEntity>>())
    {
    }

    public EducationRoleProvider(
      IServiceBll<RoleEntity> roleService,
      IServiceBll<UserEntity> userService)
    {
      _roleService = roleService;
      _userService = userService;
    }

    public override void AddUsersToRoles(string[] usernames, string[] roleNames)
    {
      throw new NotImplementedException();
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

    public override void CreateRole(string roleName)
    {
      throw new NotImplementedException();
    }

    public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
    {
      throw new NotImplementedException();
    }

    public override string[] FindUsersInRole(string roleName, string usernameToMatch)
    {
      throw new NotImplementedException();
    }

    public override string[] GetAllRoles()
    {
      throw new NotImplementedException();
    }

    public override string[] GetRolesForUser(string username)
    {
      var roles = new string[] { };
      var user = _userService
        .SelectAll()
        .FirstOrDefault(e => e.Email == username);
      if (user == null)
      {
        return roles;
      }

      var userRole = _roleService
        .SelectAll()
        .Single(r => r.RoleID == user.RoleID);

      if (userRole != null)
      {
        roles = new[] { userRole.NameRole };
      }

      return roles;
    }

    public override string[] GetUsersInRole(string roleName)
    {
      throw new NotImplementedException();
    }

    public override bool IsUserInRole(string username, string roleName)
    {
      var user = _userService.SelectAll().FirstOrDefault(e => e.Email == username);
      if (user == null)
      {
        return false;
      }

      var role = _roleService.Find(user.RoleID);
      return role != null && role.NameRole == roleName;
    }

    public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
    {
      throw new NotImplementedException();
    }

    public override bool RoleExists(string roleName)
    {
      throw new NotImplementedException();
    }
  }
}