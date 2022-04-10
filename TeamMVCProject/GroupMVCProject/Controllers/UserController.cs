using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GroupMVCProject.Models;

namespace GroupMVCProject.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddEdit(int id = 0)
        {
            UserTable usertable = new UserTable();
            return View(usertable);
        }
        [HttpPost]
        public ActionResult AddEdit(UserTable userTable)
        {
            using (DBModels db = new DBModels())
            {
                if (db.UserTables.Any(x => x.Username == userTable.Username))
                {
                    ViewBag.DuplicateMessage = "User Name already Exists.";
                        return View("AddEdit", userTable);
                }
                else
                {
                    db.UserTables.Add(userTable);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.SuccessMessage = " Saved Successfull.";
                return View("AddEdit", new UserTable());
            }
        }
    }
}