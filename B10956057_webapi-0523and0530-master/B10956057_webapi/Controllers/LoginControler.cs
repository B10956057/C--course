using B10956057_webapi.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace B10956057_webapi.Controllers
{
    public class LoginControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        List<LoginUser> userList = new List<LoginUser>
        {
            new LoginUser
            {
                Account = "123",
                Password = "123",
                Role = RoleEnum.Normal.ToString(),
                Name = "Tony",
                IsDisable = false
            },

             new LoginUser
             {
                Account = "1234",
                Password = "1234",
                Role = RoleEnum.Admin.ToString(),
                Name = "Matt",
                IsDisable = false
             }

        };
   

        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginUser loginUser)
        {
            var user = (from a in userList
                        where a.Account == loginUser.Account
                        && a.Password == loginUser.Password
                        && a.IsDisable == false
                        select a).SingleOrDefault();

            if(user == null)
            {
                ViewData["ErrorMessage"] = "'帳號與密碼有錯";
                return View();
            }
            else
            {
                var userAuthFnCode = String.Join(',', Role2Fn.Where(x => x.RoleName == user.Role).Select(x => x.FnCode).ToList());

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.Account),
                    new Claim("FullName",user.Name),
                    new Claim(ClaimTypes.Role,user.Role.ToString()),
                    new Claim("LastChanged",DateTime.Now.ToString()),
                    new Claim("AuthFnCode",String.Join(',',userAuthFnCode))
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult AccessDeny()
        {
            return View();
        }

        public class Role2FnCode
        {
            public string RoleName { get; set; }
            public string FnCode { get; set; }
        }

        List<Role2FnCode> Role2Fn = new List<Role2FnCode>
        {
            new Role2FnCode{ RoleName= RoleEnum.Admin.ToString() , FnCode = AuthFnCodeEnum.StudentMgr.ToString()},
            new Role2FnCode{ RoleName= RoleEnum.Admin.ToString() , FnCode = AuthFnCodeEnum.StudentGradesMgr.ToString()},
            new Role2FnCode{ RoleName= RoleEnum.Normal.ToString() , FnCode = AuthFnCodeEnum.StudentMgr.ToString()},
        };

        public class FncodeAuthorize : AuthorizeAttribute, IAuthorizationFilter
        {
            private readonly AuthFnCodeEnum AuthFnCode;

            public FncodeAuthorize(AuthFnCodeEnum authFnCode)
            {
                this.AuthFnCode = authFnCode;
            }
            public void OnAuthorization(AuthorizationFilterContext context)
            {
                var isAuthenticated = context.HttpContext.User.Identity.IsAuthenticated;
                if (!isAuthenticated)
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }

                var userAuthFnCode = context.HttpContext.User.FindFirst("AuthFnCode").Value.Split(',');
                var isAuth = userAuthFnCode.Contains(AuthFnCode.ToString());
                if (!isAuth)
                {
                    context.Result = new ForbidResult();
                    return;
                }
            }
        }
       

    }
}
