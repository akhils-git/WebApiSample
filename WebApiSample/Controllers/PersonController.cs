using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSample.DataSource;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    public class PersonController : ApiController
    {
        StudentSystemEntities sse = new StudentSystemEntities();

        [HttpPost]
        public Student SaveStudent(Student student)
        {
            Student std = new Student();
            std.ID = student.ID;
            std.Name = student.Name;
            std.Malayalam = student.Malayalam;
            std.English = student.English;
            std.Hindi = student.Hindi;

            sse.Students.Add(std);
            sse.SaveChanges();

            return std;
        }
        public bool SavePerson(DataSource.Person person)
        {
            DataSource.Person tempPerson = new DataSource.Person();
            tempPerson.Id = person.Id;
            tempPerson.Name = person.Name;
            tempPerson.Email = person.Email;

            return true;
        }
    }
}
