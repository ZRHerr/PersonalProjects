using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;
using PersonalSite.Models;
using System.Net.Mail;

namespace PersonalSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ApplicationDbContext _context;

        //public HomeController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    MailMessage msz = new MailMessage();
                    msz.From = new MailAddress(contact.Email);
                    msz.To.Add("zachary.r.herrera@gmail.com");
                    msz.Subject = contact.Subject;
                    msz.Body = contact.Message;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("zachary.r.herrera@gmail.com","P3rs0n@lSit3");
                    smtp.EnableSsl = true;
                    smtp.Send(msz);
                    ModelState.Clear();
                    ViewBag.Message = "Message Sent, Thank you!";
                }
                catch (Exception e)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we had a problem sending your message {e.Message}";
                }
            }
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //Fixed
        public IActionResult DownloadResume()
        {
            return File("~\\MyFile.pdf", "application/pdf", "ZRH.pdf");
        }
    }
}
