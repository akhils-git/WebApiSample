using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSample.Models;

namespace WebApiSample.Controllers
{
    public class PersonController : ApiController
    {

        public Person GetMyName()
        {

            Person p1 = new Person();
            p1.ID = 1;
            p1.Name = "Akhil";

            return p1;
        }

        public List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();

            Person p1 = new Person();
            p1.ID = 1;
            p1.Name = "Akhil";

            Person p2 = new Person();
            p2.ID = 2;
            p2.Name = "Sachin";

            Person p3 = new Person();
            p3.ID = 3;
            p3.Name = "Ann";

            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);

            return persons;
        }
    }
}
