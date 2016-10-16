using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public string Index()
        {
            return "Please call Support at <strong><u>801-555-1212</u></strong>. Thank you!";
        }

        public string Email(string name, string email)
        {
            return "Thank you " + name + ". An email will be sent to " + email;
        }

    }
}