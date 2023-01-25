using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using System.Numerics;
using System.Xml.Linq;
using mvc_temple.Models;

namespace MVC_d1.Controllers
{
    public class UserController : Controller
    {
        public ContentResult Index()
        {
            ContentResult result = new();
            result.Content = "welcome from user ";
            return result;
        }

        public JsonResult product()
        {
            JsonResult result = new JsonResult(new { name = "ali", email = "ali@", phone = "01000", willAttend = "true"});
            return result;
        }
        public ViewResult userDetiles()
        {
            return View("details");
        }

        public IActionResult getUser()
        { 
        user user =  new user()
           
            {
                name= "ali",
                email="aaa",
                phone="0122",
                willAttend="true"

            }; 
            return View("userdetails",user);
        }

        public IActionResult AddData()
        {
        
            List<user> user =SampleDate.user;


                return View("GetAll",user);
           
        }
        public IActionResult AddForm()
        {
            return View("AddForm");
        }


        public IActionResult AddUser(user users)
        {
            SampleDate.AddUser(users);


            List<user> user = SampleDate.user;
            //if (user.Count > 0)

            //{
            //    return View("GetAll", user);
            //}
            //else
            //{
            //    return Content("No products available");
            //}

            View("GetAll", user);
            if (users.willAttend == "yes")
            {
                return View("GetAll");
            }
            else
            {
                return View("thank");
            }
        }

        public IActionResult ThankUser()
        {
            return View("thank");
        }

    }
}
