using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Data;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.ViewModel.Account;

namespace RailwayNew1.Controllers
{
    public class AccountController : Controller
    {
        private RailwayContext db;

        public AccountController(RailwayContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                //User user = await db.FindAsync<User>(model.Username, model.Password);
                if (user != null)
                {
                    //if(user.EmailConfirmed==false)
                    //{
                    //    ModelState.AddModelError(string.Empty, "Вы не подтвердили свой email");
                    //    return View(model);
                    //}
                    await Authenticate(user.Username, user.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.FirstOrDefault<User>(u => u.Email == model.Email);

                if (user == null)
                {
                    string username = model.Email.Substring(0, model.Email.IndexOf("@"));

                    db.Users.Add(new User
                    {
                        Surename = model.Surename,
                        Name = model.Name,
                        Username = username,
                        Email = model.Email,
                        Phone = model.PhoneNumber,
                        Password = model.Password
                    });
                    await db.SaveChangesAsync();

                    await Authenticate(username, model.Email);

                    return RedirectToAction("Login", "Account");
                }
                else ModelState.AddModelError("", "Данный пользователь уже зарегистрирован в системе");
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = db.Users.FirstOrDefault(u => u.Email == model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("Email", "Данный пользователь отсутствует в системе");
                }
                else return RedirectToAction("ResetPassword", "Account", new { id = user.Id });

            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(int id, ResetPasswordViewModel model)
        {

            using (db = new RailwayContext(new DbContextOptions<RailwayContext>()))
            {
                if (ModelState.IsValid)
                {
                    var user = await db.Users.Where(u => u.Id == id).FirstOrDefaultAsync();
                    user.Password = model.Password;
                    await db.SaveChangesAsync();
                    return RedirectToAction("Login", "Account");
                }
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }


        private async Task Authenticate(string userName, string email)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName,email)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}