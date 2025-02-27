using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nyikoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult ListStudents()
        {
            List<Models.StudentModel> students = new List<Models.StudentModel>();

            students.Add(new Models.StudentModel { _studentNumber = "", _name = "", _surname = "", _emailAddress = ""});
            students.Add(new Models.StudentModel { _studentNumber = "", _name = "", _surname = "", _emailAddress = "" });
            students.Add(new Models.StudentModel { _studentNumber = "", _name = "", _surname = "", _emailAddress = "" });
            students.Add(new Models.StudentModel { _studentNumber = "", _name = "", _surname = "", _emailAddress = "" });
            students.Add(new Models.StudentModel { _studentNumber = "", _name = "", _surname = "", _emailAddress = "" });

            return View();
        }
    }
}