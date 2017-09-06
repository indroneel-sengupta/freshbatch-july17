using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    public class StudentController : ApiController
    {
        public static List<Student> _student = new List<Student>()
        {
            new Student() {rollNo = 1,name="Test1"},
            new Student() {rollNo = 2,name="Test2"},
            new Student() {rollNo = 3,name="Test3"},
        };
        public IEnumerable<Student> Get()
        {
            return _student;
        }
        public IEnumerable<Student> Post([FromBody] Student s)
        {
            _student.Add(s);
            return _student;
        }
    }
}
