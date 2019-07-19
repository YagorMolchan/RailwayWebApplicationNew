using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RailwayNew1.Data;
using RailwayNew1.Models.Domain.Entity;
using RailwayNew1.Models.ViewModel.Manage;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RailwayNew1.Controllers
{
    public class ManageController : Controller
    {
        public RailwayContext db;

        public ManageController(RailwayContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            EditViewModel model = null;
            User user = db.Users.FirstOrDefault(u => u.Username == User.Identity.Name);
            if (user != null)
            {
                model = new EditViewModel
                {
                    Id = user.Id,
                    Surename = user.Surename,
                    Name = user.Name,
                    Email = user.Email,
                    Phone = user.Phone
                };
                return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users.FirstOrDefaultAsync(u => u.Id == model.Id);
                user.Surename = model.Surename;
                user.Name = model.Name;
                user.Email = model.Email;
                user.Username = model.Email.Substring(0, model.Email.IndexOf("@"));
                user.Phone = model.Phone;
                await db.SaveChangesAsync();
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = db.Users.Where(u => u.Username == User.Identity.Name || u.Password == model.OldPassword).FirstOrDefault();

                if (user != null)
                {
                    user.Password = model.NewPassword;
                    await db.SaveChangesAsync();
                }
            }
            return View(model);
        }


    }
}
